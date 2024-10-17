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
    //タイマー一時停止
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
            this.time -= Time.deltaTime;//時間をマイナス
            this.timertext.GetComponent<TextMeshProUGUI>().text = this.time.ToString("F1");
        }

        //時間制限アウト
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

    //タイマーを開始にする
    public void StartTimer()
    {
        isPaused = false;
    }

    //タイマーの一時停止
    public void PausedTimer()
    {
        isPaused = true ;
    }
}
