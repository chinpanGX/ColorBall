/*-------------------------------------------------------
 * 
 *      [Target.cs]
 *      的の処理
 *      Author : 出合翔太
 * 
 --------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour, ISpawn
{
    [SerializeField] private GameObject[] _targetObject; // スポーンさせるオブジェクト
    private GM_Event _event;

    private float _time; // 時間計測
    private int _timeLeftItem;

    public bool _canSpawn { get; set; } // スポーンできるかどうか


    // Start is called before the first frame update
    void Start()
    {
        // ゲーム中はレンダリングしない
        Renderer renderer = GetComponent<Renderer>();
        renderer.enabled = false;

        _event = GameObject.Find("GameManager").GetComponent<GM_Event>();

        // 最初はすべてスポーンできる状態にする
        _canSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;

        // 残す時間～２倍の時間でスポーンできるようにする
        int random = Random.Range(_timeLeftItem, _timeLeftItem * 2 + 1);
        if(_time > random)
        {
            _time = 0;
            _canSpawn = true;
        }
    }

    public void Spawn(int index)
    {
        // 的をスポーンさせる
        GameObject obj = Instantiate(_targetObject[index], this.transform);
        _canSpawn = false;

        // 削除する時間を決める 5～10秒の間
        int destoryTime = Random.Range(5, 11);
        _timeLeftItem = destoryTime;
        Destroy(obj, destoryTime);
    }
}
