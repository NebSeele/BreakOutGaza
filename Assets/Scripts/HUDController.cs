using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour {


    [Header("HUD Elements")]
    [SerializeField] private Text livesText;
    [SerializeField] private Text scoreText;

    public int lives {set{ livesText.text = value.ToString();}}
    public int score { set { scoreText.text = value.ToString(); } }
}
