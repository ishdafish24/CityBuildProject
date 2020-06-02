using UnityEngine;
using UnityEngine.UI;

public class OilScript : MonoBehaviour
{
    public Text oilAmountText;
    public float oilAmount;


    // Update is called once per frame
    void Update()
    {
        oilAmountText.text = "Oil: " + oilAmount;
    }
}
