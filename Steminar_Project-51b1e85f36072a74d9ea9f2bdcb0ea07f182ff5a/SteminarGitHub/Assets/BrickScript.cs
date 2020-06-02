using UnityEngine;
using UnityEngine.UI;

public class BrickScript : MonoBehaviour
{
    public Text brickAmountText;
    public float brickAmount;


    // Update is called once per frame
    void Update()
    {
        brickAmountText.text = "Oil: " + brickAmount;
    }
}
