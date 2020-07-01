using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameConroler : MonoBehaviour
{
    public static GameConroler instance;
    [SerializeField]
    public PlayerMovement player;

    [SerializeField]
    Text scoreLabel;

    [SerializeField]
    GameObject gameOver;

    float minTime = 0;
    float score = 0;
    bool isPlaying = false;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        isPlaying = true;
    }

    private void Update()
    {
        if(isPlaying)
        {
            AddScore();
        }
    }

    public void BombExploded()
    {
         gameOver.SetActive(true);
         isPlaying = false;
    }

    void AddScore()
    {
        if (Time.unscaledTime > minTime)
        {
            score += 1;
            minTime = Time.unscaledTime + 1;
            scoreLabel.text = "SCORE : "+score.ToString();
        }
    }

    public void OnRetryButtonClicked()
    {
        gameOver.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
