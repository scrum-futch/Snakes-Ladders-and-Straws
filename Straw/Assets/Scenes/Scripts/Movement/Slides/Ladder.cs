using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : Slides
{

    // False to move forward
    public override int move()
    {
        int squares = exit - entrance;
        for (int i = 0; i < squares; i++)
        {
            Players[player].move(false);
        }
        return 1;
    }
    //Check if player is at the entrance
    private void Update()
    {
        for (int i = 0; i < Players.Length; i++)
        {
            if (Players[i].getLoc() == entrance)
            {
                player = i;
                move();
            }
        }
    }
}

