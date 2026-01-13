using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 20f; 
    private const float turnSpeed = 60f;
    
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    public string inputID;
    
    void Start()
    {
        
    }
    
    void FixedUpdate () {
        float moveInput = Input.GetAxis("Vertical" + inputID); 
        float turnInput = Input.GetAxis("Horizontal" + inputID); 

        transform.Translate(Vector3.forward * moveInput * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * turnInput * turnSpeed * Time.deltaTime);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}