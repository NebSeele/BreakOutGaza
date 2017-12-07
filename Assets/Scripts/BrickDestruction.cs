using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Reworking Scripts on
public class BrickDestruction : MonoBehaviour
{
    [SerializeField] private float m_despawnDuration = 5.0f;

    private void pieceScatter()
    {
        Debug.Log("Shards should scatter");
    }
    private void Awake()
    {
        Destroy(gameObject, m_despawnDuration);
    }
}