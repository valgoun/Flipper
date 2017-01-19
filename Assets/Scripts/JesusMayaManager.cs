using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JesusMayaManager : MonoBehaviour
{

    public GameObject Ball;

    public GameObject Sacrifice1;

    public GameObject Spawn1;
    //  public GameObject Sacrifice2;

    public event Action Malediction;

    private float NumberOfSacrif = 0;

    private bool SacrificeOn = false;
    private bool SacrificeTime = true;
    private float NbSacri = 0;

    public event Action RespawnBall;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (SacrificeOn == false) { NumberOfSacrif = Sacrifice1.GetComponent<SacrificeManager>().Nb_Sacrifice; }// + Sacrifice2.GetComponent<SacrificeManager>().Nb_Sacrifice;
        if (SacrificeOn == true) { SacrificeComming(); }
    }


    public void SacrificeComming()
    {
        if (NbSacri < NumberOfSacrif * 2)
        {
            if (SacrificeTime == true)
            {
                SacrificeTime = false;
                GameObject NewBall = Instantiate(Ball, Spawn1.transform.position, Spawn1.transform.rotation) as GameObject;
                NbSacri = NbSacri + 1;
                StartCoroutine(SpawnSacri());
            }
        }
        else
        {
            Sacrifice1.GetComponent<SacrificeManager>().Nb_Sacrifice = 0;
            NbSacri = 0;
            SacrificeOn = false;

        }
    }

    public void MaledictionComming()
    {
        if (Malediction != null)
        {
            Malediction();
            RespawnBall();
        }
        else
        {
            Debug.Log("Il n'esiste pas de malediction");
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (NumberOfSacrif == 0) { MaledictionComming(); } else { SacrificeOn = true; Destroy(other.gameObject);
            }
        }
    }

    IEnumerator SpawnSacri()
    {
        yield return new WaitForSeconds(2);
        SacrificeTime = true;
    }

}
