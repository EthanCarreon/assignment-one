using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inWater : MonoBehaviour
{

    float swimForward;
    float swimSideways;
    public float forwardSpeed = 500;
    public float sidewaySpeed = 500;
    Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        swimForward = Input.GetAxis("Vertical");
        swimSideways = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 boost = transform.up * swimForward * forwardSpeed * 100 * Time.deltaTime;
            rigidbody.AddForce(boost);
        }


    }
    private void FixedUpdate()
    {
        rigidbody.AddTorque(swimSideways * -sidewaySpeed * Time.deltaTime);
        Vector2 force = transform.up * swimForward * forwardSpeed * Time.deltaTime;
        rigidbody.AddForce(force);
    }
}