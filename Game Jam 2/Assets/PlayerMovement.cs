using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5f;
    public float rotationSpeed = 2f;

    public Transform playerCamera;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(-transform.forward * speed);
        // rb.AddForce(-speed, 0, 0);
        // rb.movePosition((Vector2)transform.position + (direction * speed * Timed.deltaTime));

        float x = Input.GetAxis("horizontal");
        float y = Input.GetAxis("Vertical");
        
        Vector3 move = new Vector3(x, 0f, y);

        transform.Translate(move * speed * Time.deltaTime, Space.Word);

        if(move != Vecor3.zero)
        {
            {
                Quaternion toRotation = Quaternion.LookRotation(move * Vector3.up);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            } 
        }
    }

    void FixedUpdate()
    {

        //Movement
        float xAxis = Input.GetAxis("Horizontal"); //* speed * Time.deltaTime;
        float yAxis = Input.GetAxis("Vertical");  //* speed * Time.deltaTime;

        // movemen normal
        Vector3 movement = new Vector3(xAxis, 0f, yAxis);

        Vector3 relativeMovement = Camera.main.transform.TransformVector(movement);
        relativeMovement = new Vector3(xAxis, 0, 0);

        rb.AddForce(relativeMovement * speed);

       /* if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), rotationSpeed);
        }

        transform.Translate(playerCamera.TransformDirection(movement));  */
    }
}
