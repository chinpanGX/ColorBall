/*-------------------------------------------------------
 * 
 *      [Rule.cs]
 *      ゲームルール画面
 *      Author : 出合翔太
 * 
 -------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rule : Scene
{
    // Start is called before the first frame update
    void Start()
    {
        Begin();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {            
            ChangeScene("Game");
        }
    }
}
