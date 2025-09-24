using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 50f;
    

    void Start()
    {
    }
    
    void Update () {
        float moveInput = Input.GetAxis("Vertical"); 

        float turnInput = Input.GetAxis("Horizontal"); 


        transform.Translate(Vector3.forward * moveInput * speed * Time.deltaTime);

        transform.Rotate(Vector3.up * turnInput * turnSpeed * Time.deltaTime);
    }
}