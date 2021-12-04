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
        // カメラの方向から、X-Z平面の単位ベクトルを取得
        var cameraForward = Vector3.Scale(gameObject.transform.forward, new Vector3(1, 0, 1)).normalized;
        // 方向キーの入力値とカメラの向きから、移動方向を決定
        var moveForward = cameraForward * input.y + gameObject.transform.right * input.x;

        transform.position += moveForward * Time.deltaTime * m_moveSensibility;
    }
}
