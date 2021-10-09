/*-------------------------------------------------------
 * 
 *      [GM_Score.cs]
 *      スコアを管理する
 *      Author : 出合翔太
 * 
 -------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM_Score : MonoBehaviour, ICounter
{
    [SerializeField]
    private Text _textObject; // スコアテキスト
    public int _score { get; set; } // スコア

    // Start is called before the first frame update
    void Start()
    {
        _textObject.text = "Score : " + _score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // テキストの更新
    public void UpdateText()
    {
        _textObject.text = "Score : " + _score.ToString();
    }

    public void Add(int count = 1)
    {
        _score += count;
    }

    public void Sub(int count = 1)
    {
        _score -= count;
    }
}
