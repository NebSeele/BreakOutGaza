using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bricks : MonoBehaviour {

    public GameObject BrickParticle;
    private void OnCollisionEnter()
    {
        Instantiate(BrickParticle, Transform.position, Quaternion.identity);
        GM.instance.DestroyBrick();
        Destroy(GameObject);
    }
}
