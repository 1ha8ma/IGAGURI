using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class igaguriController : MonoBehaviour
{
    Vector3 position;

    //������
    public void Shoot(Vector3 dir)
    { 
        GetComponent<Rigidbody>().AddForce (dir);
    }

    //����������
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();

        if (gameObject.transform.position.x > -3.8 && gameObject.transform.position.x < 3.8 && gameObject.transform.position.y < 10.3 && gameObject.transform.position.y > 2.7)
        {
            //���������ꏊ�̒��S����̋��������߂�
            float calc = Mathf.Pow((gameObject.transform.position.x - 0), 2.0f) + Mathf.Pow((gameObject.transform.position.y - 6.5f), 2.0f);
            calc = Mathf.Sqrt(calc);
            calc = 2 - calc;//�^�񒆂ɋ߂��قǃX�R�A�������Ȃ�悤�ɂ���
            if (calc < 0)//0�ȉ��ɂȂ����ꍇ��0
            {
                calc = 0;
            }

            //�X�R�A���Z
            ScoreManager.score += Mathf.FloorToInt(calc * 10);//FloorToInt...float��int�ɕϊ�
        }

        //�폜
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }
}
