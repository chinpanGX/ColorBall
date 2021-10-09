/*-------------------------------------------------------
 * 
 *      [GameEvent.cs]
 *      ゲームのイベントを管理
 *      Author : 出合翔太
 * 
 -------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM_Event : MonoBehaviour
{
    [SerializeField] private GameObject _gunObject; // 銃のオブジェクト
    private GM_Score _scoreManager; // スコア
    public int _settingBulletId { get; set; } // 現在、銃に設定されている弾のId

    // Start is called before the first frame update
    void Start()
    {
        _scoreManager = GetComponent<GM_Score>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore(int amount)
    {
        _scoreManager.Add(amount);
        _scoreManager.UpdateText();
    }

    public void SubScore(int amount)
    {
        _scoreManager.Sub(amount);
        _scoreManager.UpdateText();
    }

    // アイテムを取得(param'id' = "アイテムの管理番号")
    public void GetItem(int id)
    {
        _gunObject.GetComponent<Gun>().SetBullet(id); // 該当するオブジェクトを設定する
    }
}
