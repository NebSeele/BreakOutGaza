using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsControl : MonoBehaviour {

    public AudioMixer masterMixer;
    //public AudioMixer audioMixer;

    public void SetMaster (float volumeMaster)
     {
        masterMixer.SetFloat("volumeMaster", volumeMaster);
     }
/* Consult about sub mixers when an opportunity arises
    public void SetAudio(float volumeAudio)
    {
        masterMixer.SetFloat("volumeAudio", volumeAudio);
    }
 */

}
