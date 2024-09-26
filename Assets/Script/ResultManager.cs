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
        //スコア表示
        this.scoretext.GetComponent<TextMeshProUGUI>().text = "SCORE : " + ScoreManager.score.ToString("F1");

        //クリックでタイトルシーンに移行
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
