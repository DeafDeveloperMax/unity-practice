using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody objectRb;
    private float destroyZ = 12.0f; 
    
    void Start()
    {
       objectRb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        objectRb.AddForce(Vector3.forward * -speed);
        if (transform.position.z < -destroyZ)
        {
            Destroy(gameObject);
        }
    }
}
