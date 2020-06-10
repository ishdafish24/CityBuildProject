
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 20.0f;
    public float maxDistFromCenter = 40;
    public double minHeight = -10;


    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = transform.position;

        if (Input.GetKey("w") && currentPos.z < maxDistFromCenter)
        {
            currentPos.z += panSpeed * Time.deltaTime;
        }

        else if (Input.GetKey("a") && currentPos.x > maxDistFromCenter * -1)
        {
            currentPos.x -= panSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("d") && currentPos.x < maxDistFromCenter)
        {
            currentPos.x += panSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("s") && currentPos.z > maxDistFromCenter *-1)
        {
            currentPos.z -= panSpeed * Time.deltaTime;
        }

        transform.position = currentPos;




        if (Input.GetKey("c") && currentPos.y > minHeight)
        {
            currentPos.y -= panSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("v"))
        {
            currentPos.y += panSpeed * Time.deltaTime;
        }
        transform.position = currentPos;
    }
}
