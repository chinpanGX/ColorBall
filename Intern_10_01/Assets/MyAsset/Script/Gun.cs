/*-------------------------------------------------------
 * 
 *      [Gun.cs]
 *      銃の処理
 *      Author : 出合翔太
 * 
 ------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject _shotPointObject;   // 球がでる位置
    [SerializeField] private GameObject[] _m4a1Object;      // 銃の子ども
    [SerializeField] private GameObject _particleObject;  // プレイヤーのパーティクル

    private GM_Event _event; // ゲームイベントを管理するクラス
    private SE _se;

    private int _gotFirstItem; // １回目に取得したアイテムを登録しておく  
    private int _gotSeconditem;
    private int _gotBullet;  // すでに持っている球のId
    private int _itemGetCount; // アイテムを取得した回数
    private int _index; // 生成する弾の配列の番号
    private bool _canFire; // trueなら射撃ができる
    // Start is called before the first frame update
    void Start()
    {
        _se = GameObject.Find("SE").GetComponent<SE>();
        _event = GameObject.Find("GameManager").GetComponent<GM_Event>();
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
        // 射撃可能状態で右クリック
        if(_canFire)
        {
            if(Input.GetMouseButtonDown(0)) 
            {
                Fire();
            }
        }
    }

    // 弾のセット
    public void SetBullet(int id)
    {
        switch (_itemGetCount)
        {
            case 0:
                // 一回目に取得したアイテムidを覚えておく
                _gotFirstItem = id;
                _gotBullet += id;
                // 撃つ準備をする
                SetIndex();
                SetMaterial();
                SetParticle();
                _canFire = true;
                // カウンターを増やす
                _itemGetCount++;
                _se.Play(2);
                break;
            case 1:
                // １回目と同じものかチェック
                if (_gotFirstItem != id) 
                {
                    // ２回目に取得したアイテムを覚えておく
                    _gotSeconditem = id;
                    _gotBullet += id;
                    // 撃つ準備をする
                    SetIndex(); // 配列と紐づけ
                    SetMaterial();
                    SetParticle();
                    _canFire = true;
                    _itemGetCount++; // カウンターを増やす
                    _se.Play(3);
                }
                break;
            case 2:
                // １回目と取得したものを比較
                if (_gotFirstItem != id)
                {
                    // ２回目に取得したものを比較
                    if (_gotSeconditem != id)
                    {
                        _gotBullet += id;
                        // 撃つ準備をする
                        SetIndex(); // 配列と紐づけ
                        SetMaterial();
                        SetParticle();
                        _canFire = true;
                        _itemGetCount++; // カウンターを増やす
                        _se.Play(4);
                    }
                }
                break;
            default:
                break;
        }
    }

    // 初期化
    private void Init()
    {
        _canFire = false;
        _itemGetCount = 0;
        _gotBullet = 0;
        _gotSeconditem = 0;
        _gotFirstItem = 0;
        _index = 7;
        foreach (var obj in _m4a1Object)
        {
            obj.GetComponent<GunMaterialList>().SetMaterial(_index);
        }
        _particleObject.GetComponent<ParticleList>().None();
    }

    // マテリアルをセットする
    private void SetMaterial()
    {
        // 銃にマテリアルを設定
        foreach (var obj in _m4a1Object)
        {
            obj.GetComponent<GunMaterialList>().SetMaterial(_index);
        }
    }

    // パーティクルをセットする
    private void SetParticle()
    {
        _particleObject.GetComponent<ParticleList>().Spawn(_index);
    }

    // 射撃
    private void Fire()
    {
        // 球を生成する
        _shotPointObject.GetComponent<BulletSpawner>().Spawn(_index);
        _se.Play(5);
        Init();
    }

    // 取得している弾と配列の紐付け
    private void SetIndex()
    {
        // 赤
        if(_gotBullet == 1)
        {
            _index = 0;
        }
        // 緑
        else if(_gotBullet == 10)
        {
            _index = 1;
        }
        // 青
        else if(_gotBullet == 100)
        {
            _index = 2;
        }
        // 黄色
        else if(_gotBullet == 11)
        {
            _index = 3;
        }
        // ピンク
        else if(_gotBullet == 101)
        {
            _index = 4;
        }
        // 水色
        else if(_gotBullet == 110)
        {
            _index = 5;
        }
        // 白
        else if(_itemGetCount == 2)
        {
            _index = 6;
        }

        // イベントに現在設定されている弾を教える
        _event._settingBulletId = _index;
    }

}
