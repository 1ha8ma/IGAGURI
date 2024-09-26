using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    bool gameendflg;
    bool timeover;
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
