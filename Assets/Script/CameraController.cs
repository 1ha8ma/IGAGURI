using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //�e��I�u�W�F�N�g
    public Camera MainCamera;
    public Camera EffectCamera;
    public float transitionDirection = 5.0f;//�J�����̏I������
    

    //�J�����̍��W
    public Vector3 startPosition = new Vector3(0, 0, 3);//�J�����̃X�^�[�g�ʒu
    public Vector3 endPosition = new Vector3(0, 5, -10);//�J�����̃G���h�ʒu

    //���ԃ}�l�[�W���[�C���X�^���X��
    public TimeManager timermanager;

    public GameObject target = null;

    void Start()
    {
        StartCoroutine(CameraTranstion());//���f�ł��鏈���̂܂Ƃ܂�
    }

    //private IEnumerator CameraTranstion()//�t�F�[�h�A�E�g
    //{
    //    //���o�p�̃J�����̗L�������ă��C���J�����𖳌���
    //    MainCamera.enabled = false;
    //    EffectCamera.enabled = true;

    //    //�J�n���̈ʒu��ݒ�
    //    EffectCamera.transform.position = startPosition;

    //    //�o�ߎ���
    //    float elapsedTime = 0.0f;
    //    //���o�J�n(�o�ߎ��Ԃ��I�����Ԃ܂�)
    //    while (elapsedTime < transitionDirection)
    //    {
    //        //lerp�ňړ�
    //        EffectCamera.transform.position = Vector3.Lerp(startPosition, endPosition, elapsedTime / transitionDirection);
    //        elapsedTime += Time.deltaTime;
    //        //���̃t���[���܂őҋ@����
    //        yield return null;
    //    }
    //    //�J�����̈ʒu���I���ʒu�Ɏ����Ă���
    //    EffectCamera.transform.position = endPosition;

    //    //���C���J������L�������āA���o�J�����𖳌���
    //    EffectCamera.enabled = false;
    //    MainCamera.enabled = true;

    //    //���o���I�������^�C�}�[�J�n
    //    timermanager.StartTimer();
    //}

    private IEnumerator CameraTranstion()//�������炸���ƃ^�[�Q�b�g������悤�ɋ߂Â�
    {
        //���o�p�̃J�����̗L�������ă��C���J�����𖳌���
        MainCamera.enabled = false;
        EffectCamera.enabled = true;

        //�J�n���̈ʒu��ݒ�
        startPosition = new Vector3(200, 100, 300);
        EffectCamera.transform.position = startPosition;

        Vector3 add = new Vector3(0, 5, 0);
        //�o�ߎ���
        float elapsedTime = 0.0f;
        //���o�J�n(�o�ߎ��Ԃ��I�����Ԃ܂�)
        while (elapsedTime < transitionDirection)
        {
            //�����_��ݒ�
            EffectCamera.transform.LookAt(target.transform.position + add);

            //lerp�ňړ�
            EffectCamera.transform.position = Vector3.Slerp(startPosition, endPosition, elapsedTime / transitionDirection);
            elapsedTime += Time.deltaTime;
            //���̃t���[���܂őҋ@����
            yield return null;
        }
        //�J�����̈ʒu���I���ʒu�Ɏ����Ă���
        EffectCamera.transform.position = endPosition;

        //���C���J������L�������āA���o�J�����𖳌���
        EffectCamera.enabled = false;
        MainCamera.enabled = true;

        //���o���I�������^�C�}�[�J�n
        timermanager.StartTimer();
    }
}
