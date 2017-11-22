using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {
    //Lets lose a life!
    //Seems Instance in the GM handles the death counter. Is it also meant to handle Paddle and Ball destruction and reset?
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Player")
            GM.Instance.loseLife();
    }
}
