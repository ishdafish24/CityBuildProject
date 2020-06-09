﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilDrillScript : MonoBehaviour
{
    int timer = 0;
    public int waitTime = 100;
    public int oilToAdd = 1;
    public int oilCollected = 0;
    public GameObject OilText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Canvas.gameObject.SetActive(false);
        if (timer < waitTime)
        {
            timer++;
        }
        else
        {
            OilText.GetComponent<OilScript>().oilAmount += oilToAdd;
            oilCollected += oilToAdd;
            timer = 0;
        }
    }
}
