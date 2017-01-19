using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplicateur : MonoBehaviour {

    public static List<GameObject> listMultipli;
    private bool interrupt;
    public Material[] tabMateria;
    private GameObject[] findMultipli;
    private List<Multiplicateur> otherMultipli;

    private MeshRenderer couleur;

    private void Awake()
    {
        couleur = gameObject.GetComponent<MeshRenderer>();
        otherMultipli = new List<Multiplicateur>();
        findMultipli = GameObject.FindGameObjectsWithTag("multipli");
        for(int i = 0; i < findMultipli.Length; i++)
        {
            otherMultipli.Add(findMultipli[i].GetComponent<Multiplicateur>());
        }
    }

    // Use this for initialization
    void Start () {
        interrupt = false;
	}

    private void OnCollisionEnter(Collision collision)
    {
        interrupt = !interrupt;
        if (interrupt)
        {
            couleur.material = tabMateria[1];
            bool verif = true;
            for (int i = 0; i < otherMultipli.Count; i++)
            {
                if (!otherMultipli[i].GetActif())
                {
                    verif = false;
                }
            }
            if (verif)
            {
                for (int i = 0; i < otherMultipli.Count; i++)
                {
                    otherMultipli[i].Desactif();
                    //code add multiplicateur
                }
                Debug.Log("Multiplicateur");
            }
        }else
        {
            couleur.material = tabMateria[0];
        }

    }

    public bool GetActif()
    {
        return interrupt;
    }

    public void Desactif()
    {
        interrupt = false;
        couleur.material = tabMateria[0];
    }
}
