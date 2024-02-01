using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOpenOne : MonoBehaviour
{

    public GameObject platform;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        platform.SetActive(false);
    }
}
