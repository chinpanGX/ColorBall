/*-------------------------------------------------------
 * 
 *      [GameEnd.cs]
 *      ゲームを終了させる
 *      Author : 出合翔太
 * 
 -------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ゲーム終了
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
