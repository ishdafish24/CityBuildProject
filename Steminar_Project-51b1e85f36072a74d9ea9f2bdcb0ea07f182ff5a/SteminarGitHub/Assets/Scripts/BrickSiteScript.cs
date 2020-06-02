using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSiteScript : MonoBehaviour
{
    int timer = 0;
    public int waitTime = 50;
    public int bricksToAdd = 1;
    public GameObject BrickText;

    // Start is called before the first frame update
    void Start()
    {
        BrickText = GameObject.Find("MudBrickAmount");
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
            BrickText.GetComponent<BrickScript>().brickAmount += bricksToAdd;
            timer = 0;
        }
    }
}
