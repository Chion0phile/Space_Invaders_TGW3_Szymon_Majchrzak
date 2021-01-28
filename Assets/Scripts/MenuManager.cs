using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    private int HiScoreAmount;
    private int YourScoreAmount;
    private float StartTime;
    public GameObject HiScoreText;
    public GameObject YourScoreText;

    public void LoadGame()
    {
        StartTime = Time.time;
        PlayerPrefs.SetFloat("Time", StartTime);
        SceneManager.LoadScene("Game");
        PlayerPrefs.SetFloat("EnemySpeed", 0.01f);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlayScene");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    private void Awake()
    {
        HiScoreAmount = PlayerPrefs.GetInt("HiScore");
        HiScoreText.GetComponent<Text>().text = "HI SCORE: " + HiScoreAmount;
        YourScoreAmount = PlayerPrefs.GetInt("YourScore");
        YourScoreText.GetComponent<Text>().text = "YOUR SCORE: " + YourScoreAmount;
    }
}
