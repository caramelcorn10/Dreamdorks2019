﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public float sensitivityX = 5F;
    public float sensitivityY = 5F;


    public float minimumX = -90F;
    public float maximumX = 90F;


    public float minimumY = -45F;
    public float maximumY = 45F;


    float rotationY = 0F;
    float rotationX = 0f;


    void Update()
    {
        if (Input.GetAxis("LJoystick X") * sensitivityX > 1 || Input.GetAxis("LJoystick X") * sensitivityX < -1)
        {
            rotationX += Input.GetAxis("LJoystick X") * sensitivityX;
            rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);
        }
        if (Input.GetAxis("LJoystick Y") * sensitivityY > 1 || Input.GetAxis("LJoystick Y") * sensitivityY < -1)
        {
            rotationY += Input.GetAxis("LJoystick Y") * sensitivityY;
            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
        }

        transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }


}
