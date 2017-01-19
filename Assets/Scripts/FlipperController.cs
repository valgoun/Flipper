using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FlipperController : MonoBehaviour {

    public GameObject flipperL;
    public GameObject flipperR;
    public Transform axisL;
    public Transform axisR;
    public float maxAngle;
    public float minAngle;
    public float force;

    Rigidbody _rbL;
    Rigidbody _rbR;


	// Use this for initialization
	void Start () {
        _rbL = axisL.GetComponent<Rigidbody>();
        _rbR = axisR.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Left"))
        {
            _rbL.DORotate(new Vector3(0, maxAngle, 0), 1f / force).OnComplete(() => _rbL.DORotate(new Vector3(0, minAngle, 0), 1f / force));
        }

        if (Input.GetButton("Right"))
        {
            _rbR.DORotate(new Vector3(0, -maxAngle + 180, 0), 1f / force).OnComplete(() => _rbR.DORotate(new Vector3(0, -minAngle + 180, 0), 1f / force));
        }


	}
}
