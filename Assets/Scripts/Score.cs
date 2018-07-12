using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {

    public Text scoreText;

    public Text highScoreText;

    private int score;

    private int highScore;

    private string highScoreKey = "highScore";


	// Use this for initialization
	void Start () {

       // highScore.SetActive(false);

        Initialize();

        
 	}
	
	// Update is called once per frame
	void Update () {
		if(highScore < score)
        {
            highScore = score;
        }

        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();
	}

    private void Initialize()
    {
        score = 0;

        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
    }

    public void AddPoint (int point)
    {
        score = score + point;
    }

    public void Save()
    {

        PlayerPrefs.SetInt(highScoreKey, highScore);
        PlayerPrefs.Save();

        Debug.Log("HighScore Save");

        Initialize();
    }
}

