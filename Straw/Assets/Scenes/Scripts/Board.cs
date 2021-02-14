using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] Player play1;
    [SerializeField] Player play2;
    [SerializeField] Player play3;
    [SerializeField] Player play4;
    [SerializeField] GameObject text;
    //Checks to see if a players is occupying the 100 spot
    public bool win()
    {
        if (play1.getLoc() == 100)
        {
            return true;
        }
        if (play2.getLoc() == 100)
        {
            return true;
        }
        if (play3.getLoc() == 100)
        {
            return true;
        }
        if (play4.getLoc() == 100)
        {
            return true;
        }
        return false;
    }
    //Checks to see if game has been won.
    private void Update()
    {
        if(win())
        {
            if (play1.getLoc() == 100)
            {
                text.GetComponent<UnityEngine.UI.Text>().text = "Ant" + "\n Wins!";
            }
            if (play2.getLoc() == 100)
            {
                text.GetComponent<UnityEngine.UI.Text>().text = "Caterpillar" + "\n Wins!";
            }
            if (play3.getLoc() == 100)
            {
                text.GetComponent<UnityEngine.UI.Text>().text = "Snail" + "\n Wins!";
            }
            if (play4.getLoc() == 100)
            {
                text.GetComponent<UnityEngine.UI.Text>().text = "Worm" + "\n Wins!";
            }
        }
    }
}
