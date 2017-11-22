using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// I am not sure this script is even needed anymore. The important parts are now in Brick.cs
public class BrickDestruction : MonoBehaviour
{
    public GameObject destroyedVersion;

    private void OnMouseDown()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
  
    }
}