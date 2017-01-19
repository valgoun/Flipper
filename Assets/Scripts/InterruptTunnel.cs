using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterruptTunnel : MonoBehaviour {

    public bool isInterruptBase;
    public Transform tunnelLier;
    private Tunnel tunnelLierScript;
    private bool isActif;
    private List<Tunnel> tunnelUpdate;
    private GameObject[] tunnelRecup;
    private List<InterruptTunnel> listInterrupt;
    private GameObject[] findInterrupt;

    private void Awake()
    {
        tunnelLierScript = tunnelLier.GetComponent<Tunnel>();
        tunnelUpdate = new List<Tunnel>();
        if (isInterruptBase)
            isActif = true;
        else
            isActif = false;
        tunnelRecup = GameObject.FindGameObjectsWithTag("trou");
        for(int i = 0; i < tunnelRecup.Length; i++)
        {
            if(!tunnelRecup[i].transform.Equals(tunnelLier))
                tunnelUpdate.Add(tunnelRecup[i].GetComponent<Tunnel>());
        }
        listInterrupt = new List<InterruptTunnel>();
        findInterrupt = GameObject.FindGameObjectsWithTag("interruptTrou");
        for(int i = 0; i < findInterrupt.Length; i++)
        {
            listInterrupt.Add(findInterrupt[i].GetComponent<InterruptTunnel>());
        }

    }

    // Use this for initialization
    void Start () {
        if (isActif)
        {
            for(int i = 0; i < tunnelUpdate.Count; i++)
            {
                tunnelUpdate[i].Actif();
                tunnelUpdate[i].Arriver(tunnelLier);
            }
            tunnelLierScript.Desactif();
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            isActif = !isActif;
            if (isActif)
            {
                for (int i = 0; i < listInterrupt.Count; i++)
                {
                    listInterrupt[i].Desactif();
                }
                    for (int i = 0; i < tunnelUpdate.Count; i++)
                {
                    tunnelUpdate[i].Actif();
                    tunnelUpdate[i].Arriver(tunnelLier);
                }
                tunnelLierScript.Desactif();
            }
        }
    }

    public void Desactif()
    {
        isActif = false;
    }

}
