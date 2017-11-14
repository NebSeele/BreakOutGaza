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

    public void StartNewGame()
    {
        /* Testing purposes
        Debug.Log("Start New Game"); */
        SceneManager.LoadScene(m_levelName, LoadSceneMode.Single);
        
    }

    public void SelectALevel()
    {

        Debug.Log("Select Level not implemented");
    }
    public void HighScoreDisplay()
    {

        Debug.Log("High Score display not implemented");
    }
}
