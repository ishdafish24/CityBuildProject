using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BrickCollectedScript : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    public int brickCollected = 0;
    public GameObject MudBlockSite;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = "Bricks Collected: " + MudBlockSite.GetComponent<BrickSiteScript>().brickCollected;
    }
}
