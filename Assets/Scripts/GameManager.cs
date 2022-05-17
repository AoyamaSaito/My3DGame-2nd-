using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// �Q�[�����Ǘ�����X�N���v�g�A�K���ȃI�u�W�F�N�g�ɃA�^�b�`���Đݒ肷��Γ���
/// </summary>
public class GameManager : MonoBehaviour
{
    [Header("�}�E�X�J�[�\�����Q�[�����ɏ������ǂ����̐ݒ�")]
    [SerializeField] bool _hideSystemMouseCursor = false;
    [Header("�G�֘A")]
    [SerializeField, Tooltip("�G�����郌�C���[")] LayerMask _enemyLayer = default;
    /// <summary>���ݏƏ��ő_���Ă���G</summary>
    [Tooltip("���ݏƏ��ő_���Ă���G")] EnemyController _currentTarget;
    [Header("�Ə��֌W")]
    [SerializeField, Tooltip("�Ə���UI")] Image _crosshairImage;
    [SerializeField, Tooltip("�e�̃I�u�W�F�N�g")] GameObject _gunObject;
    [SerializeField, Tooltip("�e�����΂����Ray�̋���")] float _rayRange = 100f;
    [Header("�Q�[���X�^�[�g���ɌĂ΂��")]
    [SerializeField, Tooltip("�Q�[���X�^�[�g���ɌĂяo������")] UnityEngine.Events.UnityEvent _onGameStart = null;

    public void StartGame() //�Q�[���v���C������������
    {
        if (_hideSystemMouseCursor)
        {
            Cursor.visible = false;
        }
    }

    void Start()
    {

    }

    void Update()
    {
        // �Ə��̏���
        _crosshairImage.rectTransform.position = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        _gunObject.transform.rotation = Quaternion.LookRotation(ray.direction);     //// �e�̌���������ς��Ă���

        if (Physics.Raycast(ray, out hit, 1f, LayerMask.GetMask("Gun")))
        {
            Cursor.visible = false;
        }
        else
        {
            Cursor.visible = true;
        }

        //if (Physics.Raycast(ray, out hit, _rayRange))
        //{
        //    _gunObject.transform.LookAt(hit.point);    // �e�̕�����ς��Ă���(��U����Ȃ�)
        //}

        // �G���Ə��ɓ����Ă��邩���ׂ�
        bool isEnemyTargeted = Physics.Raycast(ray, out hit, _rayRange, _enemyLayer);
        _currentTarget = isEnemyTargeted ? hit.collider.gameObject.GetComponent<EnemyController>() : null;    // �O�����Z�q ? ���g���Ă���
    }

    void AddCoin()  //�G��|�������A�_���[�W��^�����Ƃ��ɃR�C�����v���C���[�ɗ^����
    {

    }

    private void OnApplicationQuit()
    {

    }
}
