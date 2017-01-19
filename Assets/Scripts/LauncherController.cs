using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LauncherController : MonoBehaviour
{

    public GameObject impact;
    public float charge;
    public float limit;
    public float attenuation;
    public float speed;

    Rigidbody _rb;
    float _force;
    Vector3 _startingPoint;

    // Use this for initialization
    void Start()
    {
        _rb = impact.GetComponent<Rigidbody>();
        _force = 0;
        _startingPoint = impact.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (_force < limit && Input.GetButton("Jump"))
        {
            impact.transform.localPosition = new Vector3(impact.transform.localPosition.x + charge / 100, impact.transform.localPosition.y, impact.transform.localPosition.z);
            _force += charge / 100;
        }

        if (Input.GetButtonUp("Jump"))
        {
            //Debug.Log("test");
            _rb.DOMove(_startingPoint + Vector3.forward * (_force / attenuation), speed).OnComplete( () => _rb.DOMove(_startingPoint, 0.2f));
            _force = 0;
        }

    }
}
