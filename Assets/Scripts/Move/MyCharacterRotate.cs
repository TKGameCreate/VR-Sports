using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inputter;

public class MyCharacterRotate : MonoBehaviour
{
    [SerializeField] private float m_rotSensibility = 1f;

    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        var input = PadInputter.RightStickAxis();
        if (Mathf.Abs(input.y) > 0.00001)
        {
            transform.localEulerAngles += (new Vector3(0, input.x, 0) * Time.deltaTime * m_rotSensibility);
        }
    }
}
