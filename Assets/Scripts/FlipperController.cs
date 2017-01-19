using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FlipperController : MonoBehaviour
{

    public GameObject flipperL;
    public GameObject flipperR;
    public Transform axisL;
    public Transform axisR;
    public float maxAngle;
    public float minAngle;
    public float force;
    public bool inverse;

    Rigidbody _rbL;
    Rigidbody _rbR;


    // Use this for initialization
    void Start()
    {
        inverse = false;
        _rbL = axisL.GetComponent<Rigidbody>();
        _rbR = axisR.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!inverse)
        {

            if (Input.GetButton("Left"))
                LeftFlipperUp();

            if (Input.GetButtonUp("Left"))
                LeftFlipperDown();

            if (Input.GetButton("Right"))
                RightFlipperUp();

            if (Input.GetButtonUp("Right"))
                RightFlipperDown();
        }
        else
        {
            if (Input.GetButton("Left"))
                RightFlipperUp();

            if (Input.GetButtonUp("Left"))
                RightFlipperDown();

            if (Input.GetButton("Right"))
                LeftFlipperUp();

            if (Input.GetButtonUp("Right"))
                LeftFlipperDown();
        }
    }

    void LeftFlipperUp()
    {
        _rbL.DORotate(new Vector3(0, maxAngle, 0), 1f / force).OnComplete(() => _rbL.DORotate(new Vector3(0, minAngle, 0), 1f / force));
    }

    void LeftFlipperDown()
    {
        _rbL.DORotate(new Vector3(0, minAngle, 0), 1f / force);
    }

    void RightFlipperUp()
    {
        _rbR.DORotate(new Vector3(0, -maxAngle + 180, 0), 1f / force).OnComplete(() => _rbR.DORotate(new Vector3(0, -minAngle + 180, 0), 1f / force));
    }

    void RightFlipperDown()
    {
        _rbR.DORotate(new Vector3(0, -minAngle + 180, 0), 1f / force);
    }
}
