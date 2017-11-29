using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This is a placeholder class for the QuickSand UV Offset "Animation"
 * 
 * When it is time for the Polish pass, then this class will be worked on.
 * 
 * Until then it will essentially do nothing.
 * 
 */
public class QuickSandAnimation : MonoBehaviour {

   [SerializeField] private float ScrollX = 0.5f;
   [SerializeField] private float ScrollY = 0.5f;

    // Update is called once per frame
    void Update () {
		float OffsetX = Time.time * ScrollX;
        float OffsetY = Time.time * ScrollY;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(OffsetX, OffsetY);
    }
}
