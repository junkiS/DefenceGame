using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameTime : MonoBehaviour
{

    public float time = 60;

    public GameObject gameOverText;

    public bool isEnd = false;

    private Manager manager;

    // Use this for initialization
    void Start()
    {

        gameOverText.SetActive(false);

        GetComponent<Text>().text = ((int)time).ToString();


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X)) {
            //一秒ずつ減らしていく
            time -= Time.deltaTime;

        }

        if (time < 0 && isEnd == false)//０になったらゲームオーバー表示 
        {
            gameOverText.SetActive(true);
            isEnd = true;

        }
        //マイナスを表示しない
        if (time < 0) time = 0;
        GetComponent<Text>().text = (time).ToString("f2");
    }
    /*
IEnumerator Gameover()
{
   if (Input.GetMouseButtonDown(0))
   {
       SceneManager.LoadScene("title");
   }
   yield return new WaitForSeconds(2.0f);

}*/

}