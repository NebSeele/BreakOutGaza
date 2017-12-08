using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMenu : MonoBehaviour {

    [SerializeField] private AudioClip m_audioClip;



    public void OnMouseDown()
    {
        GetComponent<AudioSource>().clip = m_audioClip;
        GetComponent<AudioSource>().Play();
      
    }
}
