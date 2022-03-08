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
    [SerializeField] float _rotateSpeed = 3f;
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

        Vector3 dir = Vector3.forward * v + Vector3.right * h;

        if(dir == Vector3.zero)
        {
            _rb.velocity = new Vector3(0, _rb.velocity.y, 0);
        }
        else
        {
            Quaternion rotation = Quaternion.LookRotation(dir);
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, rotation, Time.deltaTime * _rotateSpeed);
        }

        Vector3 vel = dir.normalized * _movePower;
        vel.y = _rb.velocity.y;
        _rb.velocity = vel;
    }
}
