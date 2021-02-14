using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Where the player is at
    private int location;
    //retruns location
    public int getLoc()
    {
        return location;
    }
    //The dir is the direction the player is moving, True means backwards
    // False is Forwards
    //Returns a 1
    public int move(bool dir)
    {
        if (dir)
        {
            if (location != 0)
            {
                if (location % 10 == 1 && location != 0)
                {
                    GetComponent<Transform>().Translate(Vector2.down * 10);
                    GetComponent<Transform>().Rotate(Vector2.down, 180);
                }
                else
                    GetComponent<Transform>().Translate(Vector2.left * 10);
                location--;
            }

        }
        else
        {
            if (location % 10 == 0 && location != 0)
            {
                GetComponent<Transform>().Translate(Vector2.up * 10);
                GetComponent<Transform>().Rotate(Vector2.down, 180);
            }
            else
                GetComponent<Transform>().Translate(Vector2.right * 10);

            location++;
        }
        return 1;
    }
    
}
