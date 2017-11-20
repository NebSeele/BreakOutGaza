using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakeHelper : MonoBehaviour
{

    private CameraShake m_cameraShake;
    [SerializeField] float m_shakeMultiplier = 1.0f;
    // Use this for initialization
    void Start()
    {
        m_cameraShake = Camera.main.GetComponent<CameraShake>();
    }

    private void OnCollisionEnter()
    {
        m_cameraShake.Shake(m_shakeMultiplier);
    }
}
