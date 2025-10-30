using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRb;
    private GameObject player;
    public float speed = 3.0f;
    
    void Start()
    {
        enemyRb =  GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }


    void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
        
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
    }
}
