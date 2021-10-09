/*-------------------------------------------------------
 * 
 *      [BunMaterialList.cs]
 *      銃に付けるマテリアルのリスト
 *      Author : 出合翔太
 * 
 ------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMaterialList : MonoBehaviour
{
    [SerializeField] private Material[] _materialList; // マテリアルのリスト
    // Start is called before the first frame update
    void Start()
    {
        SetMaterial(7); //デフォルト
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // マテリアルを設定する(index = 配列の番号)
    public void SetMaterial(int index)
    {
        this.GetComponent<Renderer>().material = _materialList[index];
    }
}
