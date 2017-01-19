using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ChestManager : MonoBehaviour
{

    private int Num_Led_Enter_Collider = 0;
    public List<GameObject> LedList;
    private int children;
    public event Action EventCoffre; 


    void Start()
    {
        GetChild();
    }

    void Update()
    {
    }

    void GetChild()
    {
        children = transform.childCount;
        for (int i = 0; i < children; i++)
        {
            LedList.Add(transform.GetChild(i).gameObject);
        }
    }

    public void LedOn()
    {
        if (children > Num_Led_Enter_Collider)
        {
            LedList[Num_Led_Enter_Collider].SetActive(true);
            Num_Led_Enter_Collider = Num_Led_Enter_Collider + 1;
        }
        
        if(children == Num_Led_Enter_Collider)
        {
            if(EventCoffre != null)
            {
                EventCoffre();
            }
        }

    }

   
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Ici");
            LedOn();
        }

    }


}
