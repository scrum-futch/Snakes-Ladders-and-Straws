using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slides : Movement
{
    //Fields for All Slides object
    [SerializeField] protected int entrance;
    [SerializeField] protected int exit;
    //track which player
    protected int player = 0;
    //
    public virtual int move(bool dir)
    {
        throw new System.NotImplementedException();
    }
    //Returns exit slide
    public virtual int Exit()
    {
        return exit;
    }
    //Returns entance of slide
    public virtual int Entrance()
    {
        return entrance;
    }

}

