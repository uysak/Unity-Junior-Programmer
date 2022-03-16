using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float carMovementSpeed = 20f;
    private float turnSpeed = 5f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //We move the vehicle forward
        this.transform.Translate(Vector3.forward * forwardInput * carMovementSpeed * Time.deltaTime);
        
        // We turn the vehicle
        this.transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
