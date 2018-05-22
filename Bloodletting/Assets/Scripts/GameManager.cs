using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public static double hpMultiplier;
    public static double dpsMultiplier;
   

    
    public void Introduction()
    {
        SceneManager.LoadScene("Introduction");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game level 1");
    }
 
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void AdvanceLevelHP()
    {
        PlayerBehaviour.hpMultiplier = PlayerBehaviour.hpMultiplier + 0.5;
        SceneManager.LoadScene("Game level 2");
    }
        public void AdvanceLevelDPS()
        {
        BulletHit2D.dpsMultiplier = BulletHit2D.dpsMultiplier + 0.5;
            SceneManager.LoadScene("Game level 2");
        }
    public void AdvanceLevelHP2()
    {
        PlayerBehaviour.hpMultiplier = PlayerBehaviour.hpMultiplier + 0.5;
        SceneManager.LoadScene("Game level 3");
    }
    public void AdvanceLevelDPS2()
    {
        BulletHit2D.dpsMultiplier = BulletHit2D.dpsMultiplier + 0.5;
        SceneManager.LoadScene("Game level 3");
    }
    public void AdvanceLevelHP3()
    {
        PlayerBehaviour.hpMultiplier = PlayerBehaviour.hpMultiplier + 0.5;
        SceneManager.LoadScene("Game level 4");
    }
    public void AdvanceLevelDPS3()
    {
        BulletHit2D.dpsMultiplier = BulletHit2D.dpsMultiplier + 0.5;
        SceneManager.LoadScene("Game level 4");
    }
    public void AdvanceLevelHP4()
    {
        PlayerBehaviour.hpMultiplier = PlayerBehaviour.hpMultiplier + 0.5;
        SceneManager.LoadScene("Game level 5");
    }
    public void AdvanceLevelDPS4()
    {
        BulletHit2D.dpsMultiplier = BulletHit2D.dpsMultiplier + 0.5;
        SceneManager.LoadScene("Game level 5");
    }
    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }
    public void Prelude()
    {
        SceneManager.LoadScene("Prelude");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void NextCredits()
    {
        SceneManager.LoadScene("Credits 2");
    }
    public void Quit()
    {
        Application.Quit();
    }
    // Use this for initialization
    void Start () {
   
	}
	
	// Update is called once per frame
	void Update () {
       
	}
}
