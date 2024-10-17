using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class TimeManager : MonoBehaviour
{
    GameObject timertext;
    float time = 30.0f;
    bool timeover;
    //�^�C�}�[�ꎞ��~
    private bool isPaused = true;

    // Start is called before the first frame update
    void Start()
    {
        this.timertext = GameObject.Find("Time");
        timeover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPaused)
        {
            return;
        }
        if (timeover == false)
        {
            this.time -= Time.deltaTime;//���Ԃ��}�C�i�X
            this.timertext.GetComponent<TextMeshProUGUI>().text = this.time.ToString("F1");
        }

        //���Ԑ����A�E�g
        if (time <= 0.0f)
        {
            time = 0.0f;
            timeover = true;
        }
    }

    public bool GetTimeOverflg()
    {
        return timeover;
    }

    //�^�C�}�[���J�n�ɂ���
    public void StartTimer()
    {
        isPaused = false;
    }

    //�^�C�}�[�̈ꎞ��~
    public void PausedTimer()
    {
        isPaused = true ;
    }
}
