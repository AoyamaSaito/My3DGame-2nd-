using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �v���C���[�̓����𐧌䂷��R���|�[�l���g
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class PlayerControl : MonoBehaviour
{
    //�v���C���[�̓���
    [SerializeField] float _movePower = 3f;
    [SerializeField] float _jumpPower = 3f;
    int _jumpCount = 0;
    int _maxJump = 1;

    Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // ���͂��󂯕t���ē�����
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");


    }
}
