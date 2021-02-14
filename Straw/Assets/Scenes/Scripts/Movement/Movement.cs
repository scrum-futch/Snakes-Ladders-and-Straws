using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] protected Player play1;
    [SerializeField] protected Player play2;
    [SerializeField] protected Player play3;
    [SerializeField] protected Player play4;
    protected int currentPlayer = 0;
    protected Player[] Players = new Player[4];
    //Creates the array on Players
    protected void Start()
    {
        Players[0] = play1;
        Players[1] = play2;
        Players[2] = play3;
        Players[3] = play4;
    }
    //For inheritance 
    public virtual int move()
    {
        return 0;
    }
}
