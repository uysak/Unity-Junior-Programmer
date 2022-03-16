using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject PizzaPrefab;

    public float horizontalInput;
    private float xRange = 22;

    [SerializeField] int playerMovementSpeed;
    void Start()
    {
        playerMovementSpeed = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(PizzaPrefab,this.transform.position, PizzaPrefab.transform.rotation);
        if (this.transform.position.x < -xRange)
            this.transform.position = new Vector3( -xRange, this.transform.position.y, this.transform.position.z);
        else if (this.transform.position.x > xRange)
            this.transform.position = new Vector3(xRange, this.transform.position.y, this.transform.position.z);

        horizontalInput = Input.GetAxis("Horizontal");
        this.transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * playerMovementSpeed);
    }
}
