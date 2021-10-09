/*-------------------------------------------------------
 * 
 *      [Fps.cs]
 *      フレームレートを固定する->60fps
 *      Author : 出合翔太
 * 
 -------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM_Fps : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 60; // 60fps       
    }

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
