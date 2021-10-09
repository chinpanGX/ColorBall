using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : Scene
{
    // Start is called before the first frame update
    void Start()
    {
        Begin();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            ChangeScene("Title");
        }
        else if(Input.GetMouseButton(1))
        {
            ChangeScene("Game");
        }
    }
}
