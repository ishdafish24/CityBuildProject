using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMouseOver : MonoBehaviour
{
    public GameObject Canvas;

    void OnMouseEnter()
    {
        Canvas.gameObject.SetActive(true);
    }

    void OnMouseExit()
    {
        Canvas.gameObject.SetActive(false);
    }
}
