using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    [Header("Stats")]
    [SerializeField] private bool m_destructible = true;
    private int m_hitCount = 0;
    [SerializeField] private int[] m_pointValue;


    [Header("Prefabs")]
    [SerializeField] private GameObject m_brickParticle;
    [SerializeField] private GameObject m_destroyedVersion;

    //Settting the In Game counter for remaining bricks
    void Start()
    {
        if (m_destructible)
        {
            GM.Instance.brickCount++;
            Debug.Log("Added brick to game count");
        }

       

        //m_health = m_pointValue.Length;
    }

    //What happens when a brick is hit.
    private void OnCollisionEnter()
    {
        GM.Instance.PointCounter(m_pointValue[m_hitCount]);
        m_hitCount++;


        if (m_hitCount >= m_pointValue.Length && m_destructible)
        {
            EndObject();
        }
    }

    //Lets kill the brick! With particles and destroyed versions as effects.
    //Must code in despawn of the destroyed versions in the polish passes.

    private void EndObject()
    {
        //       Instantiate(m_brickParticle, Transform.localPosition, Quaternion.identity);
        if (m_destroyedVersion != null)
        {
            Instantiate(m_destroyedVersion, transform.position, transform.rotation);
        }

        GM.Instance.DestroyBrick();
        Destroy(gameObject);
    }
}
