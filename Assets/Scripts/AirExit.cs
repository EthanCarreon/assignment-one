using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirExit : MonoBehaviour
{
    public GameObject playercamera;
    public GameObject camera;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playercamera.SetActive(false);
        camera.SetActive(true);
        player.SetActive(true);
    }
}
