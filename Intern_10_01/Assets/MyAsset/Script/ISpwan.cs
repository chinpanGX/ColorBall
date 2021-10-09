/*-------------------------------------------------------
 * 
 *      [ISpawn.cs]
 *      スポーンのインターフェイス
 *      Author : 出合翔太
 * 
 --------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpawn 
{
    // param = index = 配列の番号
    void Spawn(int index); 
}
