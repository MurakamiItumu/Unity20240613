using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //クラス唯一のインスタンスを保持するための静的な変数
    public static ScoreScript instance;

    //スコアの表示するためのtextコンポーネントとトータルスコア
    public GameObject scoreText;
    private int totalScore = 0;

    //プライベートコンストラクタ
    private void Awake()
    {
        //インスタンスが存在しない場合はこのインスタンスを設定
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);//シーンをまたいでもインスタンスを保持
        }
        //すでに存在する場合はインスタンスを破棄
        else
        {
            Destroy(gameObject);
        }
    }

    //反映されるためのメソッドを定義
    private void Start()
    {
        //初期表示
        UpdateScoreText();
    }
    //スコアを更新して、Textコンポーネントに反映する
    public void ScoreManager(int score)
    {
        totalScore += score;
        //コンポーネットに表示する
        UpdateScoreText();
    }
    //スコアをTextコンポーネントに表示するメソッド
    private void UpdateScoreText()
    {
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "Score:" + totalScore.ToString();
    }
}
