using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Priest : JobAttClass
{
    public int priestClass()
    {
        charAttClassName = attClass.Priest.ToString();
        charAttClassDescription = "A man of the holy cloth able to heal and cleanse its allies.";
        charAttClass = (int)attClass.Priest;
        Strength = 3;
        Defense = 4;
        Magical = 7;
        MagDefense = 8;
        Speed = 5;
        Luck = 6;


        Move = 3;
        Jump = 1;

        int Weapon = (int)weaponchoice.Spear;
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
            Random.Range(1,3) //Lk
        };

        return LvlUpPoints;
    }


    public List<Skills> skills = new List<Skills>();

    public void skillsList()
    {
        skills = new List<Skills>
    {
        new Skills("Anima Christi", "Soul of Christ, sanctify me. Body of Christ, save me. ",
        4,3, 10, 75,
        new Dictionary<string, int>
            {
                { "Damage", 15 }
            }),
        new Skills("Our Father", "Our Father, who art in heaven, hallowed be thy name. ",
        2,2, 15, 80,
        new Dictionary<string, int>
            {
                { "Damage", 10 }
            }),
        new Skills("Hail Mary", "Hail Mary, full of grace, the Lord is with thee.",
        2,2, 30, 25,
        new Dictionary<string, int>
            {
                { "Damage", 50 }
            }),

    };
    }

}
