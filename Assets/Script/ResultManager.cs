using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class ResultManager : MonoBehaviour
{
    GameObject scoretext;

    private void Start()
    {
        this.scoretext = GameObject.Find("scoretext");
    }

    // Update is called once per frame
    void Update()
    {
        //�X�R�A�\��
        this.scoretext.GetComponent<TextMeshProUGUI>().text = "SCORE : " + ScoreManager.score.ToString("F1");

        //�N���b�N�Ń^�C�g���V�[���Ɉڍs
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
