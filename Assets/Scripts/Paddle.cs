using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	
	public float paddleSpeed = 1f;

	//private Vector3 playerPos = new Vector3 (0, -9.5f, 0);
    private Vector3 m_playerPos = new Vector3(0, 0, 0);


    private void Start()
    {
        m_playerPos = transform.position;
    }
    // Update is called once per frame
    void Update () {
		float xPos = transform.position.x + (Input.GetAxis ("Horizontal") * paddleSpeed);
		m_playerPos = new Vector3 (Mathf.Clamp (xPos, -8f, 8f), m_playerPos.y,m_playerPos.z);
        transform.position = m_playerPos;
	}
}
