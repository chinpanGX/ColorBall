/*-------------------------------------------------------
 * 
 *      [Bullet.cs]
 *      球の処理
 *      Author : 出合翔太
 * 
 -------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GM_Event _eventManager; // ゲームイベントを管理しているスクリプト
    private SE _se; // SE

    private Vector3 _direction; // 飛んでいく方向のベクトル
    private float _power; // 飛んでいく力
    private float _speed; // 飛んでいくスピード

    // Start is called before the first frame update
    void Start()
    {
        _eventManager = GameObject.Find("GameManager").GetComponent<GM_Event>();
        _se = GameObject.Find("SE").GetComponent<SE>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RedTarget"))
        {
            // ターゲットと弾が一致しているか検証
            MatchBullettoTarget(0);
            // 当たったオブジェクトを削除
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("GreenTarget"))
        {
            // ターゲットと弾が一致しているか検証
            MatchBullettoTarget(1);
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("BlueTarget"))
        {
            // ターゲットと弾が一致しているか検証
            MatchBullettoTarget(2);
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("YellowTarget"))
        {
            // ターゲットと弾が一致しているか検証
            MatchBullettoTarget(3);
            other.gameObject.SetActive(false);
        }
        if(other.CompareTag("PinkTarget"))
        {
            // ターゲットと弾が一致しているか検証
            MatchBullettoTarget(4);
            other.gameObject.SetActive(false);
        }
        if(other.CompareTag("LightBlueTarget"))
        {
            // ターゲットと弾が一致しているか検証
            MatchBullettoTarget(5);
            other.gameObject.SetActive(false);
        }
        if(other.CompareTag("WhiteTarget"))
        {
            // ターゲットと弾が一致しているか検証
            MatchBullettoTarget(6);
            other.gameObject.SetActive(false);
        }
    }

    // ターゲットと弾が一致しているか検証する
    private void MatchBullettoTarget(int id)
    {
        // スコアの量を決める
        int i = ScoreAmount(id);
        // 弾とターゲットが一致
        if (_eventManager._settingBulletId == id)
        {
            _eventManager.AddScore(i); // スコアアップ
            _se.Play(0);
        }
        else
        {
            _eventManager.SubScore(i); // スコアダウン
            _se.Play(1);
        }
    }

    // スコアを決める
    private int ScoreAmount(int id)
    {
        if (id < 3)
        {
            return 10; // 10点
        }
        else if (id < 6 && id > 2)
        {
            return 20; // 20点
        }
        else
        {
            return 30; // 30点
        }
    }
}
