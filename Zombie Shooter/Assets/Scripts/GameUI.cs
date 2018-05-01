using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour {

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
        {
            SceneManager.LoadScene("Game Info");
        }
    }
    void Start()
    {
        UpdateUI();
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

