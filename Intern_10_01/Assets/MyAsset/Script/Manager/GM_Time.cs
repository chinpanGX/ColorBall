/*-------------------------------------------------------
 * 
 *      [GM_Time.cs]
 *      制限時間の制御
 *      Author : 出合翔太
 * 
 -------------------------------------------------------*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM_Time : MonoBehaviour
{
    [SerializeField] private Text _timeText; 
    [SerializeField] private float _timeLimit; // タイムリミット
    private SE _se;

    public float _nowTime { get; set; } // 残り時間
    public bool _finish { get; set; }　// ゲーム終了の通知

    // Start is called before the first frame update
    void Start()
    {
        _se = GameObject.Find("SE").GetComponent<SE>();
        _finish = false;
        _nowTime = _timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        _nowTime -= Time.deltaTime;
        // 制限の表示   ToString("F1") = 少数１桁表示
        _timeText.text = "Time : " + _nowTime.ToString("F1");
        
        if(_nowTime < 0)
        {            
            _finish = true;
            _nowTime = 0;
        }
    }
}
