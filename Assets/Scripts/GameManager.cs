using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool EndGame = false;
    public bool WinGame = false;
    public GameObject ScoreText;
    public GameObject HiScoreText;
    public GameObject TimerText;
    public GameObject Enemy;
    public  int ScoreAmount;
    public bool ScoreUp = false;
    public int HiScoreAmount;
    public float TimerAmount;
    public float EnemySpeedIncreaseValue;
    private float EnemySpeedIncrease;

    private void Start()
    {
        HiScoreAmount = PlayerPrefs.GetInt("HiScore");
        HiScoreText.GetComponent<Text>().text = " HI SCORE: " + HiScoreAmount;
        ScoreAmount = PlayerPrefs.GetInt("ThisPlaythrough");
        ScoreText.GetComponent<Text>().text = "SCORE: " + ScoreAmount;
    }
    private void FixedUpdate()
    {
        TimerAmount = Time.time - PlayerPrefs.GetFloat("Time");
        TimerText.GetComponent<Text>().text = "TIME: " + TimerAmount.ToString("0");
        if (EndGame)
        {
            if (HiScoreAmount < ScoreAmount)
            {
                HiScoreAmount = ScoreAmount;
            }
            PlayerPrefs.SetInt("ThisPlaythrough", 0);
            PlayerPrefs.SetInt("HiScore", HiScoreAmount);
            PlayerPrefs.SetInt("YourScore", ScoreAmount);
            HiScoreText.GetComponent<Text>().text = "HI SCORE: " + HiScoreAmount;
            SceneManager.LoadScene("EndGame");
            EndGame = false;
        }
        if (WinGame)
        {
            EnemySpeedIncrease = PlayerPrefs.GetFloat("EnemySpeed") + EnemySpeedIncreaseValue;
            PlayerPrefs.SetFloat("EnemySpeed", EnemySpeedIncrease);
            PlayerPrefs.SetInt("ThisPlaythrough", ScoreAmount);
            Debug.Log("Win");
            SceneManager.LoadScene("Game");
            HiScoreText.GetComponent<Text>().text = "HI SCORE: " + HiScoreAmount;
            WinGame = false;
        }
        if (ScoreUp)
        {
            ScoreText.GetComponent<Text>().text = "SCORE: " + ScoreAmount;
            ScoreUp = false;
        }
    }
}
