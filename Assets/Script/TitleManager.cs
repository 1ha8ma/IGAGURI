using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //�N���b�N�ŃQ�[���V�[���Ɉڍs
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
