using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertHouseScript : MonoBehaviour
{
    public GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
