using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //クリックでタイトルシーンに移行
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
