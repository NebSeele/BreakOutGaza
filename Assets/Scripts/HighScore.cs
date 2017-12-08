using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HighScore : MonoBehaviour {
    
    //Usual headers, declared Variables
    [SerializeField] private Text highScoreText;


    //This is the Main Menu High Score Controller

    
    //View the High Score
    public void ViewHighScore()
    {
        highScoreText.text = PlayerPrefs.GetInt("highScore").ToString();
    }
    
    //Erase High Score. It is public for the purposes of MenuScript
    public void EraseHighScore()
    {
        PlayerPrefs.DeleteKey("highScore");
    }

}
