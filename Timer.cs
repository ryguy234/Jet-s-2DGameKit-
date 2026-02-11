using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static float timeElapsed = 0;
    public float countDown = 10f;

    public Text timerText;
    //public Text highScore;

    void Start()
    {
        timeElapsed = countDown;
    }

    void Update()
    {
        if (timeElapsed >= 0)
        {
            timeElapsed -= Time.deltaTime;
            timerText.text = "Time: " + FormatTime(timeElapsed);
        }else SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    string FormatTime(float value)
    {
        TimeSpan t = TimeSpan.FromSeconds(value);
        return string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
    }
}