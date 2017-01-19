using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersManager : MonoBehaviour {

    public int credits;
    public int numberOfPlayers;
    public List<Player> Players;
    public Player actualPlayer;
    public int nexPlayerID;

	// Use this for initializhation
	void Start () {

        credits = 0;
        numberOfPlayers = 0;
        Players = new List<Player>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("space"))
        {
            credits++;
        }

        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            if(credits > 0)
            { 
                numberOfPlayers++;
                Players.Add(new Player(numberOfPlayers, 0));
                actualPlayer = Players[0];
                credits--;
            }
            else
            {
                Debug.Log("Insert coin");
            }
        }

        if (Input.GetKeyDown("left"))
        {
            SwitchPlayer();
        }

    }

    void SwitchPlayer()
    {
        nexPlayerID = actualPlayer.getID();

        if(actualPlayer.getID() < numberOfPlayers)
        {
            Debug.Log(actualPlayer.getID());
            actualPlayer = Players[nexPlayerID];
        }
        else if(actualPlayer.getID() == numberOfPlayers && credits > 0)
        {
            actualPlayer = Players[0];
            credits--;
        }
        else
        {
            Debug.Log("Game's over !");
        }
    }
}
