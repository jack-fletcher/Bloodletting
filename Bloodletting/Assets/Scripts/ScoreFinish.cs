using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreFinish : MonoBehaviour
{


    public Text Score = null;
    public Text HighScore = null;

    // Use this for initialization
    void Start()
    {
        PlayerPrefs.SetInt("highestScore", 0);
        if (PlayerPrefs.GetInt("highestScore") < GameUI.score){
            PlayerPrefs.SetInt("highestScore", GameUI.score);
        }
        Score.text = "Score:" + " " + GameUI.score;
        HighScore.text = "Local highscore:" + PlayerPrefs.GetInt("highestScore");
    }
 
}
	


