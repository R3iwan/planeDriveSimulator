using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 3.0f;
    public float rotationSpeed = 2;
    public float verticalInput = 4;
    public float horizontalInput = 4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        horizontalInput = Input.GetAxis("Horizontal"); 

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * horizontalInput * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * verticalInput * rotationSpeed * Time.deltaTime);
    }
}
