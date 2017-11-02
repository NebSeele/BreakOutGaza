using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    [SerializeField] private int m_health = 1;

    [SerializeField] private GameObject BrickParticle;

    private void OnCollisionEnter()
    {
 //       Instantiate(BrickParticle, Transform.localPosition, Quaternion.identity);
        GM.instance.DestroyBrick();
       
        Destroy(gameObject);
    }
}
