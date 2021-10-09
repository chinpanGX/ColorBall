/*-------------------------------------------------------
 * 
 *      [SE.cs]
 *      SEÇä«óùÇ∑ÇÈ
 *      Author : èoçá„ƒëæ
 * 
 -------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour, IAudio
{
    [SerializeField]
    private AudioClip[] _audioClips;
    private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(int index)
    {
        _audioSource.PlayOneShot(_audioClips[index]);
    }
    public  void Stop()
    {

    }
}
