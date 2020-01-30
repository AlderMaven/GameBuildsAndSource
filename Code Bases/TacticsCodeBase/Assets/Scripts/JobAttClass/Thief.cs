using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : JobAttClass
{
    public void thiefClass()
    {
        charAttClassName = "Thief";
        charAttClassDescription = "A person of low moral code with a hint of kleptomania.";

        Strength = 6;
        Defense = 4;
        Magical = 4;
        MagDefense = 4;
        Speed = 8;
        Luck = 7;


        Move = 4;
        Jump = 1;

        int Weapon = (int)weaponchoice.Dagger;
    }
}
