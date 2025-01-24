using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    const string PLAYER = "Player";
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == PLAYER)
            GetComponent<MeshRenderer>().material.color = Color.red;
        gameObject.tag = "Hit";
    }
}
