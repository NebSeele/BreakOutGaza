using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The Helper script for CameraShake.cs
public class CameraShakeHelper : MonoBehaviour
{

    private CameraShake m_cameraShake;
    [SerializeField] float m_shakeMultiplier = 1.0f;
    [SerializeField] string m_otherCollider = "Player";

    // Use this for initialization
    void Start()
    {
        m_cameraShake = Camera.main.GetComponent<CameraShake>();
    }

    private void OnCollisionEnter(Collider other)
    {
        if (other.tag == m_otherCollider)
            m_cameraShake.Shake(m_shakeMultiplier);
    }
}
