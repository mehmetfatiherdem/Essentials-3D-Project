using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public float speed = 20.0f;
    public float turnSpeed = 25.0f;
    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(speed * Time.deltaTime * verticalInput * Vector3.forward);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
          
    }

}
