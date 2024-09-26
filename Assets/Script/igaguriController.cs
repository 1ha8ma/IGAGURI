using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class igaguriController : MonoBehaviour
{
    Vector3 position;

    //投げる
    public void Shoot(Vector3 dir)
    { 
        GetComponent<Rigidbody>().AddForce (dir);
    }

    //当たった時
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();

        if (gameObject.transform.position.x > -3.8 && gameObject.transform.position.x < 3.8 && gameObject.transform.position.y < 10.3 && gameObject.transform.position.y > 2.7)
        {
            //当たった場所の中心からの距離を求める
            float calc = Mathf.Pow((gameObject.transform.position.x - 0), 2.0f) + Mathf.Pow((gameObject.transform.position.y - 6.5f), 2.0f);
            calc = Mathf.Sqrt(calc);
            calc = 2 - calc;//真ん中に近いほどスコアが高くなるようにする
            if (calc < 0)//0以下になった場合は0
            {
                calc = 0;
            }

            //スコア加算
            ScoreManager.score += Mathf.FloorToInt(calc * 10);//FloorToInt...float→intに変換
        }

        //削除
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }
}
