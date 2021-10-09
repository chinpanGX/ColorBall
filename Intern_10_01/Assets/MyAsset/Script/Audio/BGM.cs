/*-------------------------------------------------------
 * 
 *      [BGM.cs]
 *      BGMを管理する
 *      Author : 出合翔太
 * 
 -------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour, IAudio
{
    [SerializeField] private AudioClip[] _audioClips;
    private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(int index)
    {
        // 再生するオーディオを選択
        _audioSource.clip = _audioSource.GetComponent<AudioClip>();
        _audioSource.Play();
    }

    public void Stop()
    {
        _audioSource.Stop();
    }
}
