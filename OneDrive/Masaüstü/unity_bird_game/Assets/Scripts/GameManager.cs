using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject bitisEkrani, playButton;
    public Text scoreText, scoreText1;
    private int score;
    public static bool end;
    private void Start()
    {
        Time.timeScale = 0;
        InvokeRepeating("OyunuHizlandir", 1f, 10f);
    }
    public void Play()
    {
        Time.timeScale = 1;
        playButton.SetActive(false);
    }
    public void TryAgain()
    {
        end = false;
        SceneManager.LoadScene("game");
    }
    public void End()
    {
        scoreText1.text = score.ToString();
        bitisEkrani.SetActive(true);
        end = true;
        Invoke("OyunuDurdur", 2f);
    }
    public void Score(int eklenecekScore)
    {
        score+=eklenecekScore;
        scoreText.text = score.ToString();
    }

    private void OyunuDurdur()
    {
        Time.timeScale = 0;
    }
    private void OyunuHizlandir()
    {
        Time.timeScale += 0.1f;
    }

}
