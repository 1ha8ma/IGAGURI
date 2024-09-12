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

        //10�o�Ă�����
        if (igagurinum > 10)
        {
            gameendflg = true;
        }

        //�������Ԃ��߂�����
        GameObject timemanager = GameObject.Find("TimeManager");
        timeover = timemanager.GetComponent<TimeManager>().GetTimeOverflg();
        if(timeover)
        {
            gameendflg = true;
        }

        //�I�����Ă�����UI�\��
        if(gameendflg)
        {
            this.finishui.GetComponent<TextMeshProUGUI>().text = ("FINISH");
        }

        //�V�[���J��
        if (gameendflg && Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("ResultScene");
        }
    }
}
