using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float speed = 10.0f;
    void Start()
    {
        
    }
    
    void Update()
    {
        transform.Rotate(Vector3.forward * speed);
    }
}
