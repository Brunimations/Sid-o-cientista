using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            transform.Rotate(0, 0, 1);
        }

    }
}