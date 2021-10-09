/*------------------------------------------------------------
 
    [Fade.cs]
    Author : 出合翔太

    fadeの処理

    FadeOut➞画面が暗くなり、引数NextSceneNameに遷移したいシーンの名前を入れる
    FadeIN->暗くなった画面を徐々に明るくする遷移先のシーンでstart時に呼ぶ
 
 -------------------------------------------------------------*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Fade : MonoBehaviour
{
    private static Canvas _canvas;
    private static Image _image;

    private static float _time  = 1.5f; //フェードをする時間

    //フェード用Imageの透明度
    private static float _alpha = 0.0f;

    //フェードインアウトのフラグ
    private static bool _isFadeIn = false;
    private static bool _isFadeOut = false;

    private static string _nextScene;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //フラグ有効なら毎フレームフェードイン/アウト処理
        if (_isFadeIn)
        {
            //経過時間から透明度計算
            _alpha -= Time.deltaTime * _time;

            //フェードイン終了判定
            if (_alpha <= 0.0f)
            {
                _isFadeIn = false;
                _alpha = 0.0f;
            }

            //フェード用Imageの色・透明度設定
            _image.color = new Color(0.0f, 0.0f, 0.0f, _alpha);
        }
        else if (_isFadeOut)
        {
            //経過時間から透明度計算
            _alpha += Time.deltaTime * _time;

            //フェードアウト終了判定
            if (_alpha >= 1.0f)
            {
                _isFadeOut = false;
                _alpha = 1.0f;
                SceneManager.LoadScene(_nextScene);
            }

            //フェード用Imageの色・透明度設定
            _image.color = new Color(0.0f, 0.0f, 0.0f, _alpha);
        }
    }

    private static void Init()
    {
        GameObject gameObject = new GameObject("CanvasFade");
        _canvas = gameObject.AddComponent<Canvas>();
        gameObject.AddComponent<GraphicRaycaster>();
        _canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        gameObject.AddComponent<Fade>();
        _canvas.sortingOrder = 100;
        _image = new GameObject("ImageFade").AddComponent<Image>();
        _image.transform.SetParent(_canvas.transform, false);
        _image.rectTransform.anchoredPosition = Vector3.zero;
        _image.rectTransform.sizeDelta = new Vector2(9999, 9999);
    }

    //フェードイン開始
    public static void FadeIn()
    {
        if(_image == null)
        {
            Init();
        }
        _image.color = Color.black;
        _isFadeIn = true;
    }

    //フェードアウト開始
    public static void FadeOut(string name)
    {
        if (_image == null)
        {
            Init();
        }
        _nextScene = name;
        _image.color = Color.clear;
        _isFadeOut = true;
    }
}
