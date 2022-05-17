using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// �Q�[�����Ǘ�����X�N���v�g�A�K���ȃI�u�W�F�N�g�ɃA�^�b�`���Đݒ肷��Γ���
/// </summary>
public class GameManager : MonoBehaviour
{
    /// <summary>�Ə���UI(Image)</summary>
    [SerializeField] Image _crosshairImage;
    /// <summary>�e�̃I�u�W�F�N�g</summary>
    [SerializeField] GameObject _gunObject;
    /// <summary> �e�����΂����Ray�̋��� </summary>
    [SerializeField] float _rayRange = 100f;
    /// <summary>�Q�[���X�^�[�g���ɌĂяo������</summary>
    [SerializeField] UnityEngine.Events.UnityEvent _onGameStart = null;

    public void StartGame() //�Q�[���v���C������������
    {


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

        if (Physics.Raycast(ray, out hit, _rayRange))
        {
            _gunObject.transform.LookAt(hit.point);    // �e�̕�����ς��Ă���
        }
    }

    void AddCoin()  //�G��|�������ɃR�C�����v���C���[�ɗ^����
    {

    }

    private void OnApplicationQuit()
    {
        
    }
}
