using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour {
    /*Might be easier to control exit game button from its own script. 
    Won't break the Menuscript when active then
    For the PC Version only. Will crash on iOS */


    public void Quitting ()
    {
        Application.Quit();
        Debug.Log("Game has Quit! Thank You :)");
    }
}
