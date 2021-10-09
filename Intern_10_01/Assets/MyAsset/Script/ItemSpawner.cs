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
    [SerializeField] private GameObject[] _itemObject; // リスポーンさせるアイテムオブジェクト
    private Vector2 _spawnPoistion; // スポーンする位置

    // Start is called before the first frame update
    void Start()
    {
        // ゲーム中はレンダリングしない
        Renderer renderer = GetComponent<Renderer>();
        renderer.enabled = false;

        // Scaleの大きさが出現させる範囲になる
        _spawnPoistion = new Vector2(this.transform.localScale.x / 2, this.transform.localScale.z / 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 引数に該当する色のアイテムをスポーンさせる
    public void Spawn(int index)
    {
        // 出現位置を乱数で出す
        float x = Random.Range(-_spawnPoistion.x, _spawnPoistion.x);
        float z = Random.Range(-_spawnPoistion.y, _spawnPoistion.y);

        GameObject obj = Instantiate(_itemObject[index], new Vector3(x, this.transform.position.y, z), Quaternion.identity);

        // 出現から10秒たったら削除
        Destroy(obj, 20.0f);
    }
}
