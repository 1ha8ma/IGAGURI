using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //各種オブジェクト
    public Camera MainCamera;
    public Camera EffectCamera;
    public float transitionDirection = 5.0f;//カメラの終了時間
    

    //カメラの座標
    public Vector3 startPosition = new Vector3(0, 0, 3);//カメラのスタート位置
    public Vector3 endPosition = new Vector3(0, 5, -10);//カメラのエンド位置

    //時間マネージャーインスタンス化
    public TimeManager timermanager;

    public GameObject target = null;

    void Start()
    {
        StartCoroutine(CameraTranstion());//中断できる処理のまとまり
    }

    //private IEnumerator CameraTranstion()//フェードアウト
    //{
    //    //演出用のカメラの有効化してメインカメラを無効化
    //    MainCamera.enabled = false;
    //    EffectCamera.enabled = true;

    //    //開始時の位置を設定
    //    EffectCamera.transform.position = startPosition;

    //    //経過時間
    //    float elapsedTime = 0.0f;
    //    //演出開始(経過時間が終了時間まで)
    //    while (elapsedTime < transitionDirection)
    //    {
    //        //lerpで移動
    //        EffectCamera.transform.position = Vector3.Lerp(startPosition, endPosition, elapsedTime / transitionDirection);
    //        elapsedTime += Time.deltaTime;
    //        //次のフレームまで待機する
    //        yield return null;
    //    }
    //    //カメラの位置を終了位置に持ってくる
    //    EffectCamera.transform.position = endPosition;

    //    //メインカメラを有効化して、演出カメラを無効化
    //    EffectCamera.enabled = false;
    //    MainCamera.enabled = true;

    //    //演出が終わったらタイマー開始
    //    timermanager.StartTimer();
    //}

    private IEnumerator CameraTranstion()//遠くからずっとターゲットを見るように近づく
    {
        //演出用のカメラの有効化してメインカメラを無効化
        MainCamera.enabled = false;
        EffectCamera.enabled = true;

        //開始時の位置を設定
        startPosition = new Vector3(200, 100, 300);
        EffectCamera.transform.position = startPosition;

        Vector3 add = new Vector3(0, 5, 0);
        //経過時間
        float elapsedTime = 0.0f;
        //演出開始(経過時間が終了時間まで)
        while (elapsedTime < transitionDirection)
        {
            //注視点を設定
            EffectCamera.transform.LookAt(target.transform.position + add);

            //lerpで移動
            EffectCamera.transform.position = Vector3.Slerp(startPosition, endPosition, elapsedTime / transitionDirection);
            elapsedTime += Time.deltaTime;
            //次のフレームまで待機する
            yield return null;
        }
        //カメラの位置を終了位置に持ってくる
        EffectCamera.transform.position = endPosition;

        //メインカメラを有効化して、演出カメラを無効化
        EffectCamera.enabled = false;
        MainCamera.enabled = true;

        //演出が終わったらタイマー開始
        timermanager.StartTimer();
    }
}
