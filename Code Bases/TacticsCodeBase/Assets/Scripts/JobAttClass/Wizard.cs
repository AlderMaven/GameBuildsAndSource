using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : JobAttClass
{
    
    public int wizardClass()
    {
        charAttClassName = attClass.Wizard.ToString();
        charAttClassDescription = "A scholarly magic user capable of using many different magic types, but cannot master spells.";
        charAttClass = (int)attClass.Wizard;
        Strength = 3;
        Defense = 4;
        Magical = 8;
        MagDefense = 8;
        Speed = 4;
        Luck = 6;


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
        new Skills("Firespin", "sommons flames around yourself.",
        4,2, 15, 80,
        new Dictionary<string, int>
            {
                { "Damage", 10 }
            }),
        new Skills("Ice spear", "Send a spear of ice to an enemy ",
        2,2, 15, 85,
        new Dictionary<string, int>
            {
                { "Damage", 10 }
            }),
        new Skills("Lightning Bolt", "Hit an enemy with a bolt of lightning",
        2,2, 20, 80,
        new Dictionary<string, int>
            {
                { "Damage", 15 }
            }),

    };
    }






}
