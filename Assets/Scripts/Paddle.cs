using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	
	public float paddleSpeed = 1f;

	//private Vector3 playerPos = new Vector3 (0, -9.5f, 0);
    private Vector3 m_playerPos = new Vector3(0, 0, 0);
    //[SerializeField] private bool m_touchInput = false;
    

    private enum InputState { mouse, keyboard, touch};

    [SerializeField] private InputState inputState = InputState.keyboard;

    private void Start()
    {

        //Mobile Platfroms
        if (Application.platform == RuntimePlatform.IPhonePlayer)inputState = InputState.touch;
        if (Application.platform == RuntimePlatform.Android)inputState = InputState.touch;



        m_playerPos = transform.position;
    }
    // Update is called once per frame
    void Update () {

        float xPos = 0;
        Vector3 worldPoint = new Vector3();




        switch (inputState)
        {
            case InputState.keyboard:
                xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
                break;
            case InputState.mouse:
                worldPoint = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
                xPos = worldPoint.x;
                break;
            case InputState.touch:
                worldPoint = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
                xPos = worldPoint.x;
                break;
        }

/**
        if (m_touchInput)
        {
            // set xPos to mouse screen pos, this sets the base of the touch system.
            worldPoint = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
            xPos = worldPoint.x;
        }
        else
        {
            xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        }
    */


		m_playerPos = new Vector3 (Mathf.Clamp (xPos, -8f, 8f), m_playerPos.y,m_playerPos.z);
        transform.position = m_playerPos;
	}
}
