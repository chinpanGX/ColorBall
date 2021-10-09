/*-------------------------------------------------------
 * 
 *      [ItemGeneretor.cs]
 *      アイテムのジェネレーター
 *      Author : 出合翔太
 * 
 -------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    private ItemSpawner _itemSpawner;           // アイテムスポナー

    // スポーンする時間
    private float _span; // スポーンの間隔
    private float _time; //時間計測

    // Start is called before the first frame update
    void Start()
    {
        _itemSpawner = GameObject.Find("ItemSpawner").GetComponent<ItemSpawner>();
        _span = 0.75f;
        _time = 0;
    }

    // Update is called once per frame
    void Update()
    {     
        _time += Time.deltaTime;
        // スポーンする時間になったら
        if(_time > _span)
        {
            // 色をランダムで決める
            int i = (int)Random.Range(0, 3);
    
            _itemSpawner.Spawn(i); // アイテムをスポーン
            _time = 0;
        }
    }
}
