using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    void Update()
    {
        if(health <= 0) { Destroy(gameObject); }
    }
}
