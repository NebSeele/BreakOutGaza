using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GM : MonoBehaviour {

    [Header("Player Stats")]
    [SerializeField] private int m_lives = 3;
    [SerializeField] private int m_score = 0;

    [Header("Setup")]

    private int m_brickCount = 54;
    [SerializeField] private float m_resetDelay = 1f;
    //public Text livesText;
    public GameObject gameOver;
    public GameObject levelClear;
    [SerializeField] private GameObject[] m_brickPrefabs;
 //   public GameObject Sandbricks;
 //  public GameObject GoldBricks;
    public GameObject paddle;
    public GameObject deathParticles;
    private static GM instance = null;

    private GameObject clonePaddle;

    [Header("UI")]
    [SerializeField] private HUDController m_hudController;



    public static GM Instance
    {
        get
        {
            return instance;
        }

        set
        {
            instance = value;
        }
    }

    public int lives
    {
        get {return m_lives;}
        set {
            m_lives = value;
            if (m_hudController != null)
                m_hudController.lives = m_lives;
        }
    }

    public int score
    {
        get { return m_score; }
        set
        {
            m_score = value;
            if (m_hudController != null)
                m_hudController.score = m_score;
        }
    }
    // Use this for initialization
    void Start () {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);
        Setup();
    }

    public void Setup()
    {
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
        Instantiate(m_brickPrefabs[0], transform.position, Quaternion.identity);
        score = score;
    }

    void CheckGameOver()
    {
        if (m_brickCount < 1)
        {
            levelClear.SetActive(true);
            Time.timeScale = .25f;
            Invoke ("Reset, resetDelay");
        }
        if (lives < 1)
        {
            gameOver.SetActive(true);
            Time.timeScale = .25f;
            Invoke("Reset, resetDelay");
        }

    }

    private void Invoke(string v)
    {
        throw new NotImplementedException();
    }

    void Reset()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void loseLife()
    {
        lives--;
        Destroy(clonePaddle);
        Invoke("SetupPaddle", m_resetDelay);
        CheckGameOver();
    }

    void SetupPaddle()
    {
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
    }

    public void PointCounter(int value)
    {
        Debug.Log("Point Value : " + value);
        score += value;
    }

    public void DestroyBrick()
    {
        m_brickCount--;
        CheckGameOver();
    }
}
