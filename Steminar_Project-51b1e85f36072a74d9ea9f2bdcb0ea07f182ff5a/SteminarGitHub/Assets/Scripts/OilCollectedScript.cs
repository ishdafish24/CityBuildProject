using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OilCollectedScript : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    public int oilCollected = 0;
    public GameObject OilDrill;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = "Oil Collected: " + OilDrill.GetComponent<OilDrillScript>().oilCollected;
    }
}
