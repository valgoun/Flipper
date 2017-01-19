using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BumperController : MonoBehaviour {

    public GameObject Player;
    public float scoreValue;
    public float forceNeeded;
    public float pikeSpeed;
    public float wheelSpeed;

    SkinnedMeshRenderer _anim;
    Transform _wheel;

    void Start()
    {
        if(gameObject.tag == "Bumper")
        {
            _anim = gameObject.GetComponentInChildren<SkinnedMeshRenderer>();
            _wheel = transform.GetChild(0);
        }
    }
    
    void OnCollisionEnter(Collision other)
    {
        if(other.transform.tag == "Player" && other.relativeVelocity.magnitude > forceNeeded)
        {
            if (_anim != null)
            {
                DOTween.To(() => _anim.GetBlendShapeWeight(0), (x) => _anim.SetBlendShapeWeight(0, x), 100, pikeSpeed).OnComplete(() =>
                 {
                     DOTween.To(() => _anim.GetBlendShapeWeight(0), (x) => _anim.SetBlendShapeWeight(0, x), 0, pikeSpeed+2);
                 });

                _wheel.DORotate(new Vector3(0, 0, 360f), wheelSpeed, RotateMode.LocalAxisAdd).SetEase(Ease.InOutCubic);
            }


            Debug.Log("bump");
        }
    } 
}
