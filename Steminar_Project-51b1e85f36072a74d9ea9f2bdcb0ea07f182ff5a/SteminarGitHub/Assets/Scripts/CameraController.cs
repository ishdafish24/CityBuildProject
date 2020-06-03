
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 20.0f;
    public float maxDistFromCenter = 40;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 currenPos = transform.position;

        if (Input.GetKey("w") && currenPos.z < maxDistFromCenter)
        {
            currenPos.z += panSpeed * Time.deltaTime;
        }

        else if (Input.GetKey("a") && currenPos.x > maxDistFromCenter * -1)
        {
            currenPos.x -= panSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("d") && currenPos.x < maxDistFromCenter)
        {
            currenPos.x += panSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("s") && currenPos.z > maxDistFromCenter *-1)
        {
            currenPos.z -= panSpeed * Time.deltaTime;
        }

        transform.position = currenPos;




        if (Input.GetKey("z"))
        {
            currenPos.y -= panSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("x"))
        {
            currenPos.y += panSpeed * Time.deltaTime;
        }
        transform.position = currenPos;
    }
}
