using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �G�̓����𐧌䂷��R���|�[�l���g
/// </summary>
public class EnemyController : MonoBehaviour
{
    [Header("�G�̃X�e�[�^�X")]
    [SerializeField, Tooltip("�G��HP")] long _enemyHp = 100;
    [Header("�R�C���֌W")]
    [SerializeField, Tooltip("�G���U�������ۂɖႦ��R�C��")] long _coinByAttacked = 1;
    [SerializeField, Tooltip("�G��|�����ۂɖႦ��R�C��")] long _coinByDeath = 100;

    [Tooltip("�U������̂��߂̃R���C�_�[")] Collider _collider = null;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
