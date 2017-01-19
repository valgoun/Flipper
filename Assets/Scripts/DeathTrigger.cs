using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DeathTrigger : MonoBehaviour {

    public float deathDelay;

	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            DOVirtual.DelayedCall(deathDelay, () => {
                other.transform.position = new Vector3(-1f, 1.65f, 0f);
                other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            });
                
        }

    }
}
