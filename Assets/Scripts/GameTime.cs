using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameTime : MonoBehaviour
{
    private bool m_countDownStarted;
    public float m_countDownStartFrom = 3.0f;
    float m_timer;

    public GameObject gameOverText;

    public bool isEnd = false;

    Score mScore;

    // Use this for initialization
    void Start()
    {
        mScore = GameObject.Find("Score").GetComponent<Score>();
        
        m_countDownStarted = true;
        m_timer = m_countDownStartFrom;

        gameOverText.SetActive(false);

        GetComponent<Text>().text = ((int)m_timer).ToString();


    }

    // Update is called once per frame
    void Update()
    {
        if (m_countDownStarted) { 
        //一秒ずつ減らしていく
        m_timer -= Time.deltaTime;
            Debug.Log("Count: " + m_timer.ToString());

    }
        if (m_timer < 0 && isEnd == false)//０になったらゲームオーバー表示 
        {
            m_countDownStarted = false;
            Debug.Log("count end.");
            mScore.Save();
            gameOverText.SetActive(true);
            isEnd = true;

        }
        //マイナスを表示しない
        if (m_timer < 0) m_timer = 0;
        GetComponent<Text>().text = (m_timer).ToString("f2");

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