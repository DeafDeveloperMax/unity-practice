using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 15.0f;
    private float xRange = 14.0f;
    private float zMin = 0f;
    private float zMax = 15.0f;
    public float verticalInput;
    public Transform projectileSpawnPoint;

    public GameObject projectilePrefab;

    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    
        if (transform.position.z < zMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMin);
        }
        if (transform.position.z > zMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMax);
        }
        
        horizontalInput = Input.GetAxis("Horizontal1");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
                
        verticalInput = Input.GetAxis("Vertical1");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, projectileSpawnPoint.transform.position, projectilePrefab.transform.rotation);
        }
    }
}
