using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunner : JobAttClass
{
    public void gunnerClass()
    {
        charAttClassName = "Gunner";
        charAttClassDescription = "A warrior who choses forbidden technology over a blade or a bow";

        Strength = 7;
        Defense = 5;
        Magical = 4;
        MagDefense = 5;
        Speed = 6;
        Luck = 6;


        Move = 3;
        Jump = 2;

        int Weapon = (int)weaponchoice.Gun;
    }
}
