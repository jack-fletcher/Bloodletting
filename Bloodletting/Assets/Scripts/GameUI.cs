using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour {
    
    private double health;
    public static int killPoints;
    public static int score;
    private string gameInfo = "";
    private string task = "";
    public Texture2D ammoImage;
    private Rect boxReload = new Rect(Screen.width / 2, Screen.height / 2, 300, 150);
    private Rect boxRect = new Rect(10, 10, 500, 150);
    private Rect boxRect2 = new Rect(Screen.width - 185, Screen.height - 110, 175, 100);
    private string ammoInfo;
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
    void AdvanceLevel()
    {
        if ((SceneManager.GetActiveScene().name == "Game level 1") && killPoints >= 10)
        {
            SceneManager.LoadScene("Game Info 1");
            killPoints = 0;
        }
        else if ((SceneManager.GetActiveScene().name == "Game level 2") && killPoints >= 20)
        {
            SceneManager.LoadScene("Game info 2");
            killPoints = 0;
        }

        
    }
    void Start()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Game level 1":
                task = "Kill 10 cannibals!";
                break;
            case "Game level 2":
                task = "Kill 20 cannibals!";
                break;
            case "Game level 3":
                task = "Get out of the alleyway!";
                break;
            case "Game level 4":
                task = "Find your way to the helicopter!";
                break;
         
               
        }

        UpdateUI();
    }
    void HandleonUpdateHealth(double newHealth)
    {
        health = newHealth;
        UpdateUI();
    }
    void HandleonSendScore(int theScore)
    {
        score += theScore;
        UpdateUI();
    }


    public void UpdateUI()

    {

        gameInfo = "Score: " + score + "\nHealth: " + health.ToString() + "\nKill Counter:" + killPoints.ToString() + "\nTask:" + task ;
        ammoInfo = "Ammo:" + ShootBullet.clipSize + "/" + ShootBullet.maxClipSize;
        AdvanceLevel();
    }
    void OnGUI()
    {

        GUI.skin.box.fontSize = 30;
        GUI.skin.label.fontSize = 50;
       
        GUI.Box(boxRect, gameInfo);
        GUI.Box(boxRect2, ammoInfo);
        if (ShootBullet.clipSize == 0)
        {
            GUI.Label(boxReload, "RELOAD");
            

        }

        GUI.DrawTexture(new Rect(Screen.width - 110, Screen.height - 60, 40, 40), ammoImage, ScaleMode.ScaleToFit);
          
        
    }
    void Update()
    {
        UpdateUI();
    }
    }

