using UnityEngine;

public class ClothesChanger : MonoBehaviour
{
    [Header("Character Models")]
    public GameObject maleModel;
    public GameObject femaleModel;

    private bool isMale = true; // start with male

    [Header("Male Clothes")]
    public GameObject[] maleHairs;
    public GameObject[] maleHeads;
    public GameObject[] maleShirts;
    public GameObject[] malePants;
    public GameObject[] maleShoes;

    [Header("Female Clothes")]
    public GameObject[] femaleHairs;
    public GameObject[] femaleHeads;
    public GameObject[] femaleShirts;
    public GameObject[] femalePants;
    public GameObject[] femaleShoes;

    private int currentHair = 0;
    private int currentHead = 0;
    private int currentShirt = 0;
    private int currentPants = 0;
    private int currentShoes = 0;

    void Start()
    {
        SwitchGender(true); // start male
    }

    public void ToggleGender()
    {
        isMale = !isMale;
        SwitchGender(isMale);
    }

    private void SwitchGender(bool male)
    {
        isMale = male;
        maleModel.SetActive(isMale);
        femaleModel.SetActive(!isMale);

        currentHair = currentHead = currentShirt = currentPants = currentShoes = 0;

        UpdateClothes();
    }

    //loops the selection clothes and clamps it hehe
    public void NextHair() { currentHair = (currentHair + 1) % GetHairs().Length; UpdateClothes(); }
    public void PrevHair()  { currentHair  = (currentHair - 1 + GetHairs().Length) % GetHairs().Length; UpdateClothes(); }
    public void NextHead()  { currentHead  = (currentHead + 1) % GetHeads().Length; UpdateClothes(); }
    public void PrevHead()  { currentHead  = (currentHead - 1 + GetHeads().Length) % GetHeads().Length; UpdateClothes(); }
    public void NextShirt() { currentShirt = (currentShirt + 1) % GetShirts().Length; UpdateClothes(); }
    public void PrevShirt() { currentShirt = (currentShirt - 1 + GetShirts().Length) % GetShirts().Length; UpdateClothes(); }
    public void NextPants() { currentPants = (currentPants + 1) % GetPants().Length; UpdateClothes(); }
    public void PrevPants() { currentPants = (currentPants - 1 + GetPants().Length) % GetPants().Length; UpdateClothes(); }
    public void NextShoes() { currentShoes = (currentShoes + 1) % GetShoes().Length; UpdateClothes(); }
    public void PrevShoes() { currentShoes = (currentShoes - 1 + GetShoes().Length) % GetShoes().Length; UpdateClothes(); }

    private void UpdateClothes()
    {
        SetActiveOne(GetHairs(), currentHair);
        SetActiveOne(GetHeads(), currentHead);
        SetActiveOne(GetShirts(), currentShirt);
        SetActiveOne(GetPants(), currentPants);
        SetActiveOne(GetShoes(), currentShoes);
    }

    private void SetActiveOne(GameObject[] items, int activeIndex)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] != null)
                items[i].SetActive(i == activeIndex);
        }
    }
    private GameObject[] GetHairs()  => isMale ? maleHairs  : femaleHairs;
    private GameObject[] GetHeads()  => isMale ? maleHeads  : femaleHeads;
    private GameObject[] GetShirts() => isMale ? maleShirts : femaleShirts;
    private GameObject[] GetPants()  => isMale ? malePants  : femalePants;
    private GameObject[] GetShoes()  => isMale ? maleShoes  : femaleShoes;
}
