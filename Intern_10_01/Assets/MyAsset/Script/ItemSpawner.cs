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

    // Start is called before the first frame update
    void Start()
    {
        // ゲーム中はレンダリングしない
        Renderer renderer = GetComponent<Renderer>();
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 引数に該当する色のアイテムをスポーンさせる
    public void Spawn(int index)
    {
        // 出現位置を乱数で出す
        float x = Random.Range(-7, 8);
        float z = Random.Range(-7, 8);
        Vector3 position = new Vector3(x, 0.7f, z);

        GameObject obj = Instantiate(_itemObject[index], position, Quaternion.identity);

        // 出現から10秒たったら削除
        Destroy(obj, 20.0f);
    }
}
