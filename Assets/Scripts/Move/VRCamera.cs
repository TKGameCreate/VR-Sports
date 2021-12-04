using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inputter;

public class VRCamera : MonoBehaviour
{
    void Update()
    {
        MoveGyro();
        ResetGyro();
    }

    void MoveGyro()
    {
        transform.rotation = Quaternion.AngleAxis(90.0f, Vector3.right) * JyroInputter.Jyro() * Quaternion.AngleAxis(180.0f, Vector3.forward);
    }

    void ResetGyro()
    {
        /*
        if(PadInputter.CheckInputButton(PadCode.A, InputType.Down))
        {
            transform.rotation = Quaternion.identity;
        }
        */
    }
}
