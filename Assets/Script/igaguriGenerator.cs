using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class igaguriGenerator : MonoBehaviour
{
    public GameObject igaguriPrefab;
    GameObject igaguri;
    GameObject Tripletext;
    Vector3 hitposition;
    public static int thrownum;//投げたカウント

    private void Start()
    {
        this.Tripletext = GameObject.Find("Triple");
        thrownum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //クリックで毬栗を生成し続ける
        if (Input.GetMouseButtonDown(0))
        {
            thrownum++;
            igaguri = Instantiate(igaguriPrefab);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;

            igaguri.GetComponent<igaguriController>().Shoot(worldDir.normalized * 2000);
        }

        if (thrownum % 100 == 0)
        {
            this.Tripletext.GetComponent<TextMeshProUGUI>().text = "SCORE × 3";
        }
        else
        {
            this.Tripletext.GetComponent<TextMeshProUGUI>().text = "";
        }
    }
}