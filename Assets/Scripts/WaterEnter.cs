using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEnter : MonoBehaviour
{
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
        player.SetActive(true);
    }



}
