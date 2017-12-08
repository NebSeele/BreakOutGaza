using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioScript : MonoBehaviour {
    public AudioMixer masterMixer;
    //    public AudioMixer audioMixer;
    //    public AudioMixer musicMixer;

    public void SetMaster(float volumelvl)
    {
        masterMixer.SetFloat("volumeMaster", volumelvl);
    }


    public void SetAudio(float Audiolvl)
    {
        masterMixer.SetFloat("volAudio", Audiolvl);
    }

    public void SetMusic(float Musiclvl)
    {
        masterMixer.SetFloat("volMusic", Musiclvl);
    }
}
