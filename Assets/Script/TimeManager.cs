using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class TimeManager : MonoBehaviour
{
    GameObject timertext;
    float time = 10.0f;
    bool timeover;

    // Start is called before the first frame update
    void Start()
    {
        this.timertext = GameObject.Find("Time");
        timeover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeover == false)
        {
            this.time -= Time.deltaTime;
            this.timertext.GetComponent<TextMeshProUGUI>().text = this.time.ToString("F1");
        }

        //éûä‘êßå¿ÉAÉEÉg
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
}
