using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 30.0f;
    
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
