using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The Helper script for CameraShake.cs
public class CameraShakeHelper : MonoBehaviour
{
   
    private CameraShake m_cameraShake;
    [SerializeField] private float m_shakeDuration = 0.75f;
    [SerializeField] private float m_shakeMultiplier = 1.0f;
    [SerializeField] private string m_otherCollider = "Player";
    

    // Use this for initialization
    void Start()
    {
        m_cameraShake = Camera.main.GetComponent<CameraShake>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == m_otherCollider)
            m_cameraShake.Shake(m_shakeDuration, m_shakeMultiplier);
    }
}
