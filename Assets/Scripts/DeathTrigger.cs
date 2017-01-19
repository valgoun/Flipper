using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DeathTrigger : MonoBehaviour {

    public float deathDelay;
    public GameObject respawn;

	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            DOVirtual.DelayedCall(deathDelay, () => {
                other.transform.position = respawn.transform.position;
                other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            });
                
        }

    }
}
