using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilDrillScript : MonoBehaviour
{
    int timer = 0;
    public int waitTime = 50;
    public int oilToAdd = 1;
    public int oilCollected = 0;
    public GameObject OilText;
    public GameObject Canvas;

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

    void OnMouseDown()
    {
        Canvas.gameObject.SetActive(true); 
    }

    void OnMouseUp()
    {
        Canvas.gameObject.SetActive(false);
    }
}
