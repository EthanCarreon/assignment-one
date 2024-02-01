using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 10f;
    public float jumpSpeed = 5f;
    float jumpVar = 3;
    public Transform ground;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        Vector2 horizontalMovement = new Vector2(horizontal, 0);

        transform.Translate(horizontalMovement * speed * Time.deltaTime);

        if (jumpVar >= 2)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.Translate(Vector2.up * 2f);
                jumpVar -= 1;
            }
        }
        else
        {

        }

    }

    private void OnCollisionEnter2D(Collision2D ground)
    {
        jumpVar = 3;

    }


}
