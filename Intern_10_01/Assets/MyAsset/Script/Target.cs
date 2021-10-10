/*-------------------------------------------------------
 * 
 *      [Target.cs]
 *      的の処理
 *      
 * 
 --------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    
    private float _interval;
    private float _time;

    public float _destoryTime  { get; set; }
   
    // Start is called before the first frame update
    void Start()
    {
        _destoryTime = Random.Range(5, 21);
        _interval = 1.0f;
        _time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        _destoryTime -= Time.deltaTime;

        if(_destoryTime <= 3)
        {
            this.GetComponent<Renderer>().enabled = !this.GetComponent<Renderer>().enabled;
        }
        if(_destoryTime < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
