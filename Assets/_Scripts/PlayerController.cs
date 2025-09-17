using UnityEngine;

//[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    //public GameObject bulletePrefab;
    //public Transform muzzle;
    //private CharacterController _cc;

    //public float speed = 10;
    //public int health;

    void Start()
    {
        //_cc = GetComponent<CharacterController>(); //Access character controller
    }

    void Update()
    {
        //Input 
        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");
        //Vector3 direction = new Vector3(horizontal, 0, vertical);

        //Movement
        //_cc.SimpleMove(direction.normalized * speed);

        //Shooting
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Instantiate(bulletePrefab, muzzle.position, muzzle.rotation);
        //}

        //Health System
        //if (health <= 0)
        //{
        //    Destroy(gameObject);
        //}
    }

}
