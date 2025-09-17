using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletePrefab;
    public Transform muzzle;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletePrefab, muzzle.position, muzzle.rotation);
        }
    }
}
