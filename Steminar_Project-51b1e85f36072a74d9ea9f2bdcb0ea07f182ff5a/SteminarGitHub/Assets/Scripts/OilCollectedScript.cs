using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OilCollectedScript : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    public int oilCollected = 0;
    int timer = 0;
    int waitTime;
    public GameObject OilDrill;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        OilDrill = GameObject.Find("OilDrill");
        waitTime = OilDrill.GetComponent<OilDrillScript>().waitTime;
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
            oilCollected += OilDrill.GetComponent<OilDrillScript>().oilToAdd;
            timer = 0;
        }
        textMesh.text = "Oil Collected: " + oilCollected;
    }
}
