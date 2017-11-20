using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour {


    [Header("HUD Elements")]
    [SerializeField] private Text livesText;
    [SerializeField] private Text scoreText;

    [Header("End Menu Elements")]
    [SerializeField] private Image m_gameOverText;
    [SerializeField] private Image m_levelClearedText;
    [SerializeField] private GameObject m_endMenu;
    private RectTransform m_endMenuRectTransform;
    private Vector3 m_endMenuBasePos;

    public int lives {set{ livesText.text = value.ToString();}}
    public int score { set { scoreText.text = value.ToString(); } }

    void Start()
    {
        m_endMenuRectTransform = m_endMenu.GetComponent<RectTransform>();
        m_endMenuBasePos = m_endMenuRectTransform.position;
        m_endMenuRectTransform.position = new Vector3(m_endMenuBasePos.x, -1000, m_endMenuBasePos.z);// fix this, its not in the correct place. dont know why

        m_levelClearedText.enabled = false;
        m_gameOverText.enabled = false;
    }

    public void DisplayEnd (bool levelCleared)
    {
        if (levelCleared)
        {
            m_levelClearedText.enabled = true;
        }
        else
        {
            m_gameOverText.enabled = true;
        }

        // Play anim in the future
        m_endMenuRectTransform.position = m_endMenuBasePos;
    }
    

}
