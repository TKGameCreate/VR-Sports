using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inputter;

public class MyCharacterMover : MonoBehaviour
{
    [SerializeField] private float m_moveSensibility = 1f;

    void Start()
    {
        transform.localEulerAngles = Vector3.zero;
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        var input = PadInputter.LeftStickAxis();
        // �J�����̕�������AX-Z���ʂ̒P�ʃx�N�g�����擾
        var cameraForward = Vector3.Scale(gameObject.transform.forward, new Vector3(1, 0, 1)).normalized;
        // �����L�[�̓��͒l�ƃJ�����̌�������A�ړ�����������
        var moveForward = cameraForward * input.y + gameObject.transform.right * input.x;

        transform.position += moveForward * Time.deltaTime * m_moveSensibility;
    }
}
