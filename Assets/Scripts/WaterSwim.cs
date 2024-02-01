using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSwim : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject playerSwim;
    public GameObject player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerSwim.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerSwim.SetActive(false);
    }

}
