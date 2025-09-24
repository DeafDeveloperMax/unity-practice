using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;
    private Vector2 moveInput;


    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveInput.x, 0f, moveInput.y) * moveSpeed;
        controller.Move(movement * Time.fixedDeltaTime);
    }
    
    private float speed = 2.0f;
    public GameObject character;

    void Update () {
        KeyCode d = KeyCode.RightArrow;
        if (Input.GetKeyDown(d)){
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        KeyCode a = KeyCode.LeftArrow;
        if (Input.GetKeyDown(a)){
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        KeyCode w = KeyCode.UpArrow;
        if (Input.GetKeyDown(w)){
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        KeyCode s = KeyCode.DownArrow;
        if (Input.GetKeyDown(s)){
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
    }
}