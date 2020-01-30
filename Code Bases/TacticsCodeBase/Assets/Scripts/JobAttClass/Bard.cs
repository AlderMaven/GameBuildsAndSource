using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bard : JobAttClass
{
    public int bardClass()
    {
        charAttClassName = attClass.Bard.ToString();
        charAttClassDescription = "A person whose words will hurt you";
        charAttClass = (int)attClass.Bard;
        Strength = 3;
        Defense = 5;
        Magical = 5;
        MagDefense = 7;
        Speed = 6;
        Luck = 7;


        Move = 3;
        Jump = 1;

        int Weapon = (int)weaponchoice.Dagger;
        int ArmorHead = (int)Armorchoice.HelmetLight;
        int ArmorChest = (int)Armorchoice.ChestLight;
        int ArmorArms = (int)Armorchoice.ArmsLight;
        int ArmorLegs = (int)Armorchoice.LegsLight;
        skillsList();
        return charAttClass;
    }
    public int[] GetLvlUpPoints()
    {
        int[] LvlUpPoints = new int[9] {
            Random.Range(1,4),// HP
            Random.Range(2,6),//MP
            Random.Range(5,10),//Mastery
            Random.Range(1,2),// Str
            Random.Range(1,2),// Def
            Random.Range(3,4),// Mag
            Random.Range(2,4),//MgDef
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
        new Skills("SpitFire", "Start Droping rhymes so hot everyone is getting burned.",
        4,2, 15, 80,
        new Dictionary<string, int>
            {
                { "Damage", 10 }
            }),
        new Skills("IceCold", "Calls out enemy in a cypher with a cold 16. ",
        2,2, 15, 85,
        new Dictionary<string, int>
            {
                { "Damage", 10 }
            }),
        new Skills("Thunderstruct", "Start channeling the words of ACDC.",
        2,2, 20, 80,
        new Dictionary<string, int>
            {
                { "Damage", 15 }
            }),

    };
    }



}
