/*-------------------------------------------------------
 * 
 *      [TargetGenerator.cs] 
 *      的のジェネレータ―
 *      Author : 出合翔太
 * 
 -------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{
    private GameObject[] _targetObjects;
    private int _targetNum; // ターゲットの数

    private float _time;
    private float _span = 2.0f; // 2秒 

    // Start is called before the first frame update
    void Start()
    {
        // ゲームオブジェクトの取得
        _targetNum = GameObject.FindGameObjectsWithTag("Target").Length; // オブジェクトの数を数える
        _targetObjects = GameObject.FindGameObjectsWithTag("Target");
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        if (_time > _span)
        {
            // リスポーンできる状態のものを探す
            for (int i = 0; i < _targetNum; i++)
            {
                // リスポーンできる状態を発見
                if (_targetObjects[i].GetComponent<Target>()._canSpawn)
                {
                    // 1/10の確率でリスポーンしない
                    int random = (int)Random.Range(0, 11);
                    if (random != 0)
                    {
                        int cube = (int)Random.Range(0, 7);
                        _targetObjects[i].GetComponent<Target>().Spawn(cube);
                    }
                }
            }
            _time = 0;
        }
    }
}
