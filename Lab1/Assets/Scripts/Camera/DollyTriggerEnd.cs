﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollyTriggerEnd : MonoBehaviour
{
    //Reference to the virtual cam on dolly
    public GameObject dollyCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //if unity chan collides with the trigger box then deactivate the camera
        if (other.gameObject.name == "unitychan")
        {
            dollyCam.SetActive(false);
        }
    }
}
