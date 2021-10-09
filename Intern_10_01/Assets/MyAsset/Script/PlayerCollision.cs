/*-------------------------------------------------------
 * 
 *      [PlayerCollision.cs]
 *      プレイヤーの当たり判定
 *      Author : 出合翔太
 * 
 -------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private GM_Event _event;
    // Start is called before the first frame update
    void Start()
    {
        // GameEventのスクリプトを参照
       _event = GameObject.Find("GameManager").GetComponent<GM_Event>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    //　アイテムを拾う
    public void OnTriggerEnter(Collider other)
    {
        // 赤
        if (other.gameObject.CompareTag("RedItem"))
        {
            _event.GetItem(1);
            other.gameObject.SetActive(false);
        }
        // 緑
        if (other.gameObject.CompareTag("GreenItem"))
        {
            _event.GetItem(10);
            other.gameObject.SetActive(false);
        }
        // 青
        if (other.gameObject.CompareTag("BlueItem"))
        {
            _event.GetItem(100);
            other.gameObject.SetActive(false);
        }
    }
}
