using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsControl : MonoBehaviour {

    public AudioMixer masterMixer;
    public AudioMixer audioMixer;
    public AudioMixer musicMixer;

    /*
     *Lets leave for now. We only need Audio

    public Dropdown resolutionDropdown;
     Resolution[] resolutions;


     private void Start()
     {
       resolutions =  Screen.resolutions;

         resolutionDropdown.ClearOptions();

         List<string> options = new List<string>();

         int currentResolutionIndex = 0;
         for (int i = 0; i < resolutions.Length; i++)
         {
             string option = resolutions[i].width + " x " + resolutions[i].height;
             options.Add(option);

             if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height )
             {
                 currentResolutionIndex = i;
             }
         }

         resolutionDropdown.AddOptions(options);
         resolutionDropdown.value = currentResolutionIndex;
         resolutionDropdown.RefreshShownValue();
     }
         public void SetQuality(int qualityIndex)
         {
         QualitySettings.SetQualityLevel(qualityIndex);
         }

     public void SetFullScreen (bool isFullscreen)
     {
         Screen.fullScreen = isFullscreen;
     }
     */


    public void SetMaster(float volumeMaster)
    {
        masterMixer.SetFloat("volumeMaster", volumeMaster);
    }


     public void SetAudio(float volumeAudio)
      {
           masterMixer.SetFloat("volumeAudio", volumeAudio);
      }
    public void SetMusic(float volumeMusic)
    {
        masterMixer.SetFloat("volumeAudio", volumeMusic);
    }

}
