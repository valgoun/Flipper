using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunnel : MonoBehaviour {

    private bool open;
    private Transform tunnelArr;
    private Vector3 pos, scaleTemp;


    private void Awake()
    {
        open = false;
        pos = new Vector3();
        scaleTemp = new Vector3();
    }

    // Use this for initialization
    void Start () {
    }



    private void OnTriggerStay(Collider other)
    {
        if (other.tag.Equals("ball") && open)
        {
            if(Mathf.Abs(other.transform.position.x - transform.position.x) < 0.1 && Mathf.Abs(other.transform.position.z - transform.position.z) < 0.1)
            {
                Rigidbody rigi = other.GetComponent<Rigidbody>();
                rigi.velocity = Vector3.zero;
                rigi.useGravity = false;
                pos.Set(tunnelArr.position.x, tunnelArr.position.y + (other.transform.localScale.y / 2), tunnelArr.position.z);
                rigi.MovePosition(pos);
                

                rigi.useGravity = true;
            }
        }
    }

    public void Actif()
    {
        open = true;
    }

    public void Desactif()
    {
        open = false;
    }

    public void Arriver(Transform p_tunnel)
    {
        tunnelArr = p_tunnel;
    }

}
