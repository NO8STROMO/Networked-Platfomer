﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour {

    public Movement movement;
    public float rotation;

    /// <summary>
    /// Call method to rotate wheels
    /// </summary>
    void Update ()
    {
        Rotate();
	}

    /// <summary>
    /// Based on which truck way the truck is facing rotate the wheels in the approriapte directions around the Z axis
    /// </summary>
    void Rotate()
    {
        bool movementRight = Input.GetKey(KeyCode.RightArrow);
        bool movementLeft = Input.GetKey(KeyCode.LeftArrow);

        if (movementRight)
        {
            transform.Rotate(new Vector3(0, 0, -rotation));
        }

        if (movementLeft)
        {
            transform.Rotate(new Vector3(0, 0, rotation));
        }
    }
}
