using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class ScoreManager : MonoBehaviour
{
    GameObject scoretext;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        this.scoretext = GameObject.Find("Scoretext");
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //当たった場所からスコアをとる

        //スコア表示
        this.scoretext.GetComponent<TextMeshProUGUI>().text = "SCORE : " + score.ToString("F1");
    }
}
