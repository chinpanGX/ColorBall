using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : Scene
{
    private GM_Time _timeManager;
    private GM_Score _scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        Begin();
        _timeManager = GameObject.Find("GameManager").GetComponent<GM_Time>();
        _scoreManager = GameObject.Find("GameManager").GetComponent<GM_Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timeManager._finish)
        {
            // リザルト表示するスコアを入れる
            ResultScore.SetScore(_scoreManager._score);
            ChangeScene("Result");
        }
    }
}
