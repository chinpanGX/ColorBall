using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour
{
    [SerializeField]
    private Text _text; // スコアテキスト
    private SE _se;
    private static int _lastScore;
    private int _pivotScore = 180; // 基準の得点

    // Start is called before the first frame update
    void Start()
    {
        _se = GameObject.Find("SE").GetComponent<SE>();
        
        if(_lastScore > _pivotScore )
        {
            _se.Play(0);
        }
        // 
        else
        {
            _se.Play(1);
        }

        _text.text = "Score : " + _lastScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ゲーム終了時に設定する
    public static void SetScore(int score)
    {
        _lastScore = score;
    }
}
