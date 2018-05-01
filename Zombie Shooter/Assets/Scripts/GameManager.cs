using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    public void StartGame()
    {
        SceneManager.LoadScene("Game level 1");
    }
    public void EndGame()
    {
        SceneManager.LoadScene("Game level 2");
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void AdvanceLevel()
    {
        SceneManager.LoadScene("Game level 2");
    }
    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }
    public void Introduction()
    {
        SceneManager.LoadScene("Introduction");
    }
    bool isMute;

    public void Mute()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
    } 
        // Use this for initialization
        void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
