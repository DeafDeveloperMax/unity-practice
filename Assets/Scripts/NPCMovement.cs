using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    private float speed = 5f;
    void Start()
    {
        
    }
    
    void Update()
    {
        transform.Translate(Vector3.forward * speed  * Time.deltaTime);
    }
}
