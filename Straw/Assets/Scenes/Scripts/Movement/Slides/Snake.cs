using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : Slides
{
    
    // False to move back
    public override int move()
    {
        int squares = exit - entrance;
        for (int i = 0; i < squares; i++)
        {
            Players[player].move(true);
        }
        return 1;
    }
    //Check if player is at the entrance
    private void Update()
    {
        for (int i = 0; i < Players.Length; i++)
        {
            if (Players[i].getLoc() == exit)
            {
                player = i;
                move();
            }
        }

    }
}
