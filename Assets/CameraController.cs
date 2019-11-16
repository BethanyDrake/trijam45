using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public float verticalRotationSpeed;
    public float horizontalRotationSpeed;


    // Update is called once per frame
    void Update()
    {


        float upSpeed = Input.GetAxis("Vertical") * verticalRotationSpeed;
        float rightSpeed = Input.GetAxis("Horizontal") * horizontalRotationSpeed;

        transform.Rotate(-upSpeed, 0, 0);
        transform.Rotate(0, rightSpeed, 0, Space.World);


    }
}
