using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpForce = 5f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        PrintInstruction();
    }

    void Update()
    {
        
        MovePlayer();

        if (Input.GetKeyDown(KeyCode.Space))
        {
             Debug.Log("Space Pressed");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move using arrow keys or wasd");
        Debug.Log("Don't bump into objects!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}