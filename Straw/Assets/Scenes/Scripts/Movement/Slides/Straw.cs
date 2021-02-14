using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straw : Slides
{
    //Checks to see if that player has enter the straw already
    private bool[] entered = new bool[4];
    private void Start()
    {
        Players[0] = play1;
        Players[1] = play2;
        Players[2] = play3;
        Players[3] = play4;
        for (int i = 0; i < Players.Length;i++)
            entered[i] = false;
    }
    // False on entrance, and true on Exit, It is to dicate which direction is the piece moving
    public override int move(bool dir)
    {
        if (!entered[player])
        {
            int squares = exit - entrance;
            for (int i = 0; i < squares; i++)
            {
                Players[player].move(dir);
            }
        }
        return 1;
    }
    //Check if player is at the entrance or exit
    private void Update()
    {
        for (int i = 0; i < Players.Length; i++)
        {
            if (Players[i].getLoc() == entrance)
            {
                player = i;
                move(false);
                entered[i] = true;
            }
            else if (Players[i].getLoc() == exit)
            {
                player = i;
                move(true);
                entered[i] = true;
            }
            else
            {
                entered[i] = false;
            }
        }
    }
}
