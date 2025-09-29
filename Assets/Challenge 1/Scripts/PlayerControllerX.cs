using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    
    void Start()
    {

    }
    
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical1");
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.right * verticalInput * Time.deltaTime * rotationSpeed);
    }
}
