using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class blockScript : MonoBehaviour
{
    public int score = 10;
    //なにかとぶつかったときビルドインメソッド
    private void OnCollisionEnter(Collision collision)
    {
        //スコアをScorescriptに追加
        if(ScoreScript.instance != null)
        {
            ScoreScript.instance.ScoreManager(score);
        }
        else
        {
            Debug.LogError("インスタンスがありません");
        }
        //ゲームオブジェクトを排除
        Destroy(gameObject);
    }
}
