using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HighScore : MonoBehaviour {
    
    //Usual headers, declared Variables
    public int scoreCarryOver;
    private int m_highScoreContainer;
    private Text highScore;
    [SerializeField] private Text m_currentHighScore;

    //Lets set up the array

    
    //View the High Scores
    public void ViewHighScore()
    {
        m_currentHighScore.text = PlayerPrefs.GetInt("highScore").ToString();
    }
    
    //Erase High Score. It is public for the purposes of MenuScript
    public void EraseHighScore()
    {
    //    PlayerPrefs.DeleteKey("highScore", m_highScoreContainer);
    }

    //Lets bring score over from the GM script via scoreCarryOver
    void CheckHighScore ()
    { 
     if (scoreCarryOver > PlayerPrefs.GetInt("highScore", m_highScoreContainer))
        {
            PlayerPrefs.SetInt("highScore", m_highScoreContainer);
            scoreCarryOver = 0;
        }
    }
}
