using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SacrificeManager : MonoBehaviour
{

    public float Nb_Sacrifice = 0;

    public event Action RespawnBall;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Nb_Sacrifice = Nb_Sacrifice + 1;
            RespawnBall();
        }
    }
}
