using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterExit : MonoBehaviour
{
    public GameObject player;
    public GameObject block;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        player.SetActive(false);
        block.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.SetActive(true);
    }
}
