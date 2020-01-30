using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : JobAttClass
{
    public int fighterClass()
    {
        charAttClassName = "Fighter";
        charAttClassDescription = "A master of martial combat, can use a variety of weapons and armor";

        Strength = 8;
        Defense = 7;
        Magical = 4;
        MagDefense = 4;
        Speed = 5;
        Luck = 5;


        Move = 4;
        Jump = 1;

        int Weapon = (int)weaponchoice.Axe;
        int ArmorHead = (int)Armorchoice.HelmetMedium;
        int ArmorChest = (int)Armorchoice.ChestMedium;
        int ArmorArms = (int)Armorchoice.ArmsMedium;
        int ArmorLegs = (int)Armorchoice.LegsMedium;
        skillsList();
        return charAttClass;
    }
    public int[] GetLvlUpPoints()
    {
        int[] LvlUpPoints = new int[9] {
            Random.Range(2,5),// HP
            Random.Range(1,4),//MP
            Random.Range(5,10),//Mastery
            Random.Range(2,3),// Str
            Random.Range(2,3),// Def
            Random.Range(1,2),// Mag
            Random.Range(1,2),//MgDef
            Random.Range(1,2),//Sp
            Random.Range(1,2) //Lk
        };

        return LvlUpPoints;
    }



    public List<Skills> skills = new List<Skills>();

    public void skillsList()
    {
        skills = new List<Skills>
    {
        new Skills("Cyclone", "Spin Around hitting everything",
        4,1, 10, 70,
        new Dictionary<string, int>
            {
                { "Damage", 10 }
            }),
        new Skills("Axe Throw", "Throws the Axe at an enemy (it comes back) ",
        2,1, 15, 70,
        new Dictionary<string, int>
            {
                { "Damage", 10 }
            }),
        new Skills("One Punch", "My weapon of choice is these hands",
        4,1, 20, 100,
        new Dictionary<string, int>
            {
                { "Damage", 15 }
            }),

    };
    }


}
