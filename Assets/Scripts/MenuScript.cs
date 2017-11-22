using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    [SerializeField] private string m_levelName;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //New Game on the main menu, starts from the start
    public void StartNewGame()
    {
        /* Testing purposes
        Debug.Log("Start New Game"); */
        Time.timeScale = 1f;
        SceneManager.LoadScene(m_levelName, LoadSceneMode.Single);
        
    }

    //Return to the Main Menu. For In game menu's
    public void ReturnToMenu()
    {
        /* Testing purposes
        Debug.Log("Return to Menu"); */
        Time.timeScale = 1f;
        SceneManager.LoadScene("menu", LoadSceneMode.Single);

    }

    //Lets retry the level. Why won't this work?
    public void RetryLevel()
    {
        /* Testing purposes
        Debug.Log("Retry the Leve."); */
        Time.timeScale = 1f;
        SceneManager.GetActiveScene();

    }

    //Select a Level. It will not be implemented in the November or December builds due to Time and Scope restraints of only having one level.
    public void SelectALevel()
    {

        Debug.Log("Select Level not implemented");
    }

    //Display High Score. Will implement this system when the High Score system is fleshed out for the Polish build.
    public void HighScoreDisplay()
    {

        Debug.Log("High Score display not implemented");
    }

    //Quit to Windows. Will implement in the PC Version of the project. Not needed for Mobile version.
    public void QuitToWindows()
    {

        Debug.Log("Quit to Windows not implemented");
    }
}
