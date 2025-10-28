using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float speed;
    
    void Start()
    {
        
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal1");
        transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * speed);
    }
}
