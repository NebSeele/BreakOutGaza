using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollision : MonoBehaviour {

    [SerializeField] private AudioClip m_audioClip;
    [SerializeField] private string m_otherCollider = "Player";


    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == m_otherCollider)
        {
            GetComponent<AudioSource>().clip = m_audioClip;
            GetComponent<AudioSource>().Play();
        }
    }
}