using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variables
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        // Take input from user - Input ( class )
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        // Equivalent to -> transform.Translate(0 * Time.deltaTime * (speed), 0 * Time.deltaTime * speed, 1 * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // moving player to right ( + value ) and left ( - value ) 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
