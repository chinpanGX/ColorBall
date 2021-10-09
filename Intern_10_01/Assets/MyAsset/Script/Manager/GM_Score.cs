/*-------------------------------------------------------
 * 
 *      [GM_Score.cs]
 *      �X�R�A���Ǘ�����
 *      Author : �o���đ�
 * 
 -------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM_Score : MonoBehaviour, ICounter
{
    [SerializeField]
    private Text _textObject; // �X�R�A�e�L�X�g
    public int _score { get; set; } // �X�R�A

    // Start is called before the first frame update
    void Start()
    {
        _textObject.text = "Score : " + _score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // �e�L�X�g�̍X�V
    public void UpdateText()
    {
        _textObject.text = "Score : " + _score.ToString();
    }

    public void Add(int count = 1)
    {
        _score += count;
    }

    public void Sub(int count = 1)
    {
        _score -= count;
    }
}
