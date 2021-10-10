/*-------------------------------------------------------
 * 
 *      [BulletSpawner.cs]
 *      弾のスポナー
 *      Author : 出合翔太
 * 
 -------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class BulletSpawner : Spawner
{
    [SerializeField] private GameObject[] _bulletObject;
    private float _power = 5000.0f;
    
    private void Awake()
    {
        // ゲーム中はレンダリングしない
        Renderer renderer = GetComponent<Renderer>();
        renderer.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // インスタンスの生成(param = 'index' 配列の番号)
    public override void Spawn(int index)
    {
        GameObject bullet = Instantiate(_bulletObject[index], transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * _power);

        // ある程度たったら捨てる
        Destroy(bullet, 5.0f);
    }
}
