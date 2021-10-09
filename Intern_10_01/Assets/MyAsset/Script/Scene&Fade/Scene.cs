/*-------------------------------------------------------
 * 
 *      [Scene.cs]
 *      �V�[����ς���֐������N���X
 *      Author : �o���đ�
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

    // �V�[����ς���
    protected virtual void ChangeScene(string name)
    {
        Fade.FadeOut(name);
    }
}
