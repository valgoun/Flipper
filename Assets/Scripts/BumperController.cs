using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour {

    public GameObject Player;
    public float scoreValue;
    public float forceNeeded;
    
    void OnCollisionEnter(Collision other)
    {
        if(other.transform.tag == "Player" && other.relativeVelocity.magnitude > forceNeeded)
        {
            //score
            Debug.Log("bump");
        }
    } 
}
