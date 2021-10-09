/*-------------------------------------------------------
 * 
 *      [ItemSpawner.cs]
 *      アイテムのスポナー
 *      Author : 出合翔太
 * 
 -------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour, ISpawn
{
    [SerializeField] GameObject _playerObject;      // プレイヤー
    [SerializeField] private GameObject[] _itemObject; // リスポーンさせるアイテムオブジェクト

    private float _spawnOffset = 1.0f; // プレイヤーの位置からどれくらい離れてスポーンするか
    private Vector2 _spawnPositionMax; // 最大の範囲

    // Start is called before the first frame update
    void Start()
    {
        // ゲーム中はレンダリングしない
        Renderer renderer = GetComponent<Renderer>();
        renderer.enabled = false;

        // Scaleの大きさが出現させる範囲になる
        _spawnPositionMax = new Vector2(this.transform.localScale.x / 2, this.transform.localScale.z / 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 引数に該当する色のアイテムをスポーンさせる
    public void Spawn(int index)
    {
        // プレイヤーの位置を取得する
        var playerPosition = _playerObject.transform.position;
        float min = Mathf.Pow(_spawnOffset, 2);
        float max = Mathf.Pow(_spawnPositionMax.x, 2);

        // 出現位置を乱数で出す
        float x = Random.Range(-_spawnPositionMax.x, _spawnPositionMax.x);
        float z = Random.Range(-_spawnPositionMax.y, _spawnPositionMax.y);

        // 絶対値を出す
        float xAbs = Mathf.Abs(Mathf.Pow(x, 2));
        float zAbs = Mathf.Abs(Mathf.Pow(z, 2));

        // 範囲内かどうか
        if (max > xAbs + zAbs && xAbs + zAbs > min)
        {
            GameObject obj = Instantiate(_itemObject[index], new Vector3(x, this.transform.position.y, z), Quaternion.identity);
            
            // 出現から10秒たったら削除
            Destroy(obj, 20.0f);
        }
    }
}
