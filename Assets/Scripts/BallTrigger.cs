using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class BallTrigger : MonoBehaviour
{
    public GameObject ball;
    public Transform spawnpoint;
    float numBall = 0;
    public float maxBall = 5;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (numBall == maxBall)
        {
            Debug.Log("Max Ball test");
        }
        else
        {
            Instantiate(ball, spawnpoint.position, spawnpoint.rotation);
            ball.SetActive(true);
            numBall++;
        }
        
    }
}
