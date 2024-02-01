using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class ButtonOne : MonoBehaviour
{
    public GameObject platform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (platform.activeInHierarchy)
        {
            platform.SetActive(false);
        }
        else
        {
            platform.SetActive(true);
        }
    }
}
