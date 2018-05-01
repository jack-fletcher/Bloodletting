using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour {
    private bool changeable = true;
    private int health;
    private int score;
    private string gameInfo = "";
    private Rect boxRect = new Rect(10, 10, 300, 50);
    void OnEnable()
    {
        PlayerBehaviour.OnUpdateHealth += HandleonUpdateHealth;
        AddScore.OnSendScore += HandleonSendScore;
    }
    void OnDisable()
    {
        PlayerBehaviour.OnUpdateHealth -= HandleonUpdateHealth;
        AddScore.OnSendScore -= HandleonSendScore;
    }
    void advanceLevel()
    {
        if (score > 99 && score < 199)
        {if (changeable == true)
            {
                changeable = false;
                SceneManager.LoadScene("Game Info 1");
                
            }
          
        }
        if (score > 199 && score < 299)
        {
            SceneManager.LoadScene("Game Info 2");
        }
    }
    void Start()
    {
        UpdateUI();
        DontDestroyOnLoad(this.gameObject);
    }
    void HandleonUpdateHealth(int newHealth)
    {
        health = newHealth;
        UpdateUI();
    }
    void HandleonSendScore(int theScore)
    {
        score += theScore;
        UpdateUI();
        advanceLevel();
    }
    void UpdateUI()
    {
        gameInfo = "Score: " + score.ToString() + "\nHealth: " + health.ToString();
    }
    void OnGUI()
    {
        GUI.Box(boxRect, gameInfo);
    }

    }

