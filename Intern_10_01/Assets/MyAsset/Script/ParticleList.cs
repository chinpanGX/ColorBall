/*-------------------------------------------------------
 * 
 *      [ParticleList.cs]
 *      プレイヤーにつけるパーティクル
 *      Author : 出合翔太
 * 
 -------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleList : MonoBehaviour, ISpawn
{
    [SerializeField] private GameObject[] _particleObjects; // パーティクル
    GameObject _nowParticle; // 今のパーティクル

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void None()
    {
        Destroy(_nowParticle);
    }

    public void Spawn(int index)
    {
        Destroy(_nowParticle);
        _nowParticle = Instantiate(_particleObjects[index], this.transform);
    }
}
