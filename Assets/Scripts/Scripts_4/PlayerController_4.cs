using UnityEngine;

public class PlayerController_4 : MonoBehaviour
{
    private Rigidbody playerRb;
    private GameObject focalPoint;
    public float speed = 5.0f;
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }
    
    
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical1");
        playerRb.AddForce(focalPoint.transform.forward * forwardInput * speed);
    }
}
