using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //�N���b�N�Ń^�C�g���V�[���Ɉڍs
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
