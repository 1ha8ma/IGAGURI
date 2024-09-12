using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    bool gameendflg;
    bool timeover;
    int igagurinum;
    GameObject finishui;

    // Start is called before the first frame update
    void Start()
    {
        finishui = GameObject.Find("Endnotice");
        gameendflg = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject igagurigenerator = GameObject.Find("igaguriGenerator");
        igagurinum = igagurigenerator.GetComponent<igaguriGenerator>().GetIgagurinum();

        //10個出ていたら
        if (igagurinum > 10)
        {
            gameendflg = true;
        }

        //制限時間を過ぎたら
        GameObject timemanager = GameObject.Find("TimeManager");
        timeover = timemanager.GetComponent<TimeManager>().GetTimeOverflg();
        if(timeover)
        {
            gameendflg = true;
        }

        //終了していたらUI表示
        if(gameendflg)
        {
            this.finishui.GetComponent<TextMeshProUGUI>().text = ("FINISH");
        }

        //シーン遷移
        if (gameendflg && Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("ResultScene");
        }
    }
}
