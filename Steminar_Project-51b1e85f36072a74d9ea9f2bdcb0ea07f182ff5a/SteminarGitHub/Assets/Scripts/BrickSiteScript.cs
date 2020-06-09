using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSiteScript : MonoBehaviour
{
    int timer = 0;
    public int waitTime = 100;
    public int bricksToAdd = 1;
    public int brickCollected = 0;
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
            brickCollected += bricksToAdd;
            timer = 0;
        }
    }
}
