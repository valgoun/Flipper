using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedPoint : MonoBehaviour {

    public int point = 100;

    private void OnCollisionEnter(Collision collision)
    {
        //code point
        Debug.Log("bonus "+point);
        //animation de collision
    }
}
