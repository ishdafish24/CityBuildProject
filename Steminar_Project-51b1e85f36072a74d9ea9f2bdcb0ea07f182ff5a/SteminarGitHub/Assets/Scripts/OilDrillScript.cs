using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilDrillScript : MonoBehaviour
{
    int timer = 0;
    public int waitTime = 50;
    public int oilToAdd = 1;
    public GameObject OilText;

    // Start is called before the first frame update
    void Start()
    {
        OilText = GameObject.Find("OilAmount");
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < waitTime)
        {
            timer++;
        }
        else
        {
            OilText.GetComponent<OilScript>().oilAmount += oilToAdd;
            timer = 0;
        }
    }
}
