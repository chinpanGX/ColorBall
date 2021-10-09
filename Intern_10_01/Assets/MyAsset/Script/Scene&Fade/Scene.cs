/*-------------------------------------------------------
 * 
 *      [Scene.cs]
 *      シーンを変える関数を持つクラス
 *      Author : 出合翔太
 *  
 -------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected virtual void Begin()
    {
        Fade.FadeIn();
    }

    // シーンを変える
    protected virtual void ChangeScene(string name)
    {
        Fade.FadeOut(name);
    }
}
