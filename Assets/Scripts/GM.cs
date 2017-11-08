using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GM : MonoBehaviour {

    public int lives = 3;
    public int bricks = 54;
    public float resetDelay = 1f;
    public Text livesText;
    public Image gameOver;
    public Image levelClear;
    [SerializeField] private GameObject[] m_bricks;
 //   public GameObject Sandbricks;
 //  public GameObject GoldBricks;
    public GameObject paddle;
    public GameObject deathParticles;
    private static GM instance = null;

    private GameObject clonePaddle;

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
        Instantiate(m_bricks[0], transform.position, Quaternion.identity);
    }

    void CheckGameOver()
    {
        if (bricks < 1)
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
        livesText.text = "Lives:" + lives;
        Destroy(clonePaddle);
        Invoke("SetupPaddle", resetDelay);
        CheckGameOver();
    }

    void SetupPaddle()
    {
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
    }

    public void DestroyBrick()
    {
        bricks--;
        CheckGameOver();
    }
}
