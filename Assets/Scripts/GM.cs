using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GM : MonoBehaviour
{
	//Declarations of our classes, arrays etc...
	[Header ("Level Stats")]
	[SerializeField] private int m_lives = 3;
	[SerializeField] private bool m_infiniteLives = false;
	[SerializeField] private int m_score = 0;
    [SerializeField] private int m_brickDestroyedBonus = 0;
	private bool m_levelEnded = false;
	private bool m_levelCleared = false;

	[Header ("Level Setup")]
	private int m_brickCount = 0;
//	[SerializeField] private float m_resetDelay = 1f;

	[SerializeField] private GameObject[] m_brickPrefabs;

	[SerializeField]  private GameObject m_paddlePrefab;
	public GameObject deathParticles;
	private static GM instance = null;

	private GameObject clonePaddle;

	[Header ("UI")]
	[SerializeField] private HUDController m_hudController;


	//Our Instance
	public static GM Instance {
		get {
			return instance;
		}

		set {
			instance = value;
		}
	}

	//Lets display our lives. Sends to the HUD Controller
	public int lives {
		get { return m_lives; }
		set {
			m_lives = value;
			if (m_hudController != null)
				m_hudController.lives = m_lives;
		}
	}

	//Lets display our score. Sends to the HUD Controller
	public int score {
		get { return m_score; }
		set {
			m_score = value;
			if (m_hudController != null)
				m_hudController.score = m_score;
		}
	}

	//This is how many Bricks we have.
	public int brickCount {
		get { return m_brickCount; }
		set { m_brickCount = value; }
	}

	// Use this for initialization
	//Get our GM to boot the Instance up first
	private void Awake ()
	{
		if (Instance == null)
			Instance = this;
		else if (Instance != this)
			Destroy (gameObject);

		if (m_hudController == null)
			Debug.LogWarning ("HUD Controller not set");
	}

	//Upon startup we initiate Setup
	void Start ()
	{
		Setup ();
	}

	//Setting up the Paddle, Bricks and the score.
	public void Setup ()
	{
		SetupPaddle ();
		//Brick Set up
		//Instantiate(m_brickPrefabs[0], transform.position, Quaternion.identity);
		score = score;
	}

	//Is our Game Over? If it is did we clear the level?
	void CheckGameOver ()
	{
		if (m_brickCount < 1) {
			m_levelEnded = true;
			m_levelCleared = true;
		}
		if (lives < 1) {
			m_levelEnded = true;
			m_levelCleared = false;
		}

		if (m_levelEnded) {

            // Check if new high score
            if (PlayerPrefs.GetInt("highScore") < m_score){
                //Trigger for high score reward
                PlayerPrefs.SetInt("highScore", m_score);
            }

			if (m_hudController != null)
				m_hudController.DisplayEnd (m_levelCleared);
			Time.timeScale = .25f;


			//Invoke("Reset, resetDelay");
		}

	}

	//I may need to go back over why this exists in the first place.
	private void Invoke (string v)
	{
		throw new NotImplementedException ();
	}

	/*  Level Reset now works in MenuScript, awaiting feedback on whether to keep or not
    void Reset()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    */

	//Lets lose a life for hitting the deathzone. We need to destroy and reset the ball and Paddle
	public void loseLife ()
	{
          
		if (!m_infiniteLives)
        {
            lives--;
        }

        m_brickDestroyedBonus = 0;
		
		Destroy (clonePaddle);

		CheckGameOver ();

		if (!m_levelEnded)
			SetupPaddle ();

	}

	//Clones a Paddle Mesh.
	void SetupPaddle ()
	{
		clonePaddle = Instantiate (m_paddlePrefab, transform.position, transform.rotation) as GameObject;
		//clonePaddle = Instantiate(m_paddlePrefab, transform.position, Quaternion.identity) as GameObject;
	}

    //Our scoring system
	public void PointCounter (int value)
	{
		if (!m_levelEnded) {
            // Debug.Log("Point Value : " + value);
            {
                score += value;
                if (m_brickDestroyedBonus >= 10)
                {
                    score += (value + (1000 * m_lives));

                    m_brickDestroyedBonus = 0;
                }
            }
        }
        if (m_brickCount < 1)
        {
            score += value + 500;
            if (m_levelCleared)
                { score += (value + (2000 * m_lives)); }
        }

	}
	//Lets destroy bricks, as long as there are bricks to destroy
	public void DestroyBrick ()
	{
		if (!m_levelEnded) {
			m_brickCount--;
            m_brickDestroyedBonus++;
		}
		CheckGameOver ();
	}
}
