using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

    private int ID;
    private int score;


    public Player(int id, int s)
    {
        this.ID = id;
        this.score = s;
    }


    public int getID()
    {
        return this.ID;
    }

    public int getScore()
    {
        return this.score;
    }

}
