using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monk : JobAttClass
{
    

    public int monkClass() {
        charAttClassName = attClass.Monk.ToString();
        charAttClassDescription = "A master of the body and soul, can use physical and spiritual attack";
        charAttClass = (int)attClass.Monk;
        Strength = 4;
        Defense = 7;
        Magical = 4;
        MagDefense = 7;
        Speed = 5;
        Luck = 6;

        // AddPrereq(typeof(Thief), 3);
        // AddPrereq(typeof(Squire), 2); 

        Move = 4;
        Jump = 2;

        int Weapon = (int)weaponchoice.Spear;
        int ArmorHead = (int)Armorchoice.HelmetMedium;
        int ArmorChest = (int)Armorchoice.ChestMedium;
        int ArmorArms = (int)Armorchoice.ArmsMedium;
        int ArmorLegs = (int)Armorchoice.LegsMedium;
        skillsList();
        return charAttClass;
    }
    public int [] GetLvlUpPoints()
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

    public void skillsList() {
        skills = new List<Skills>
    {
        new Skills("Whirwind", "Spin Around hitting everything",
        4,1, 5, 70,
        new Dictionary<string, int>
            {
                { "Damage", 5 }
            }),
        new Skills("Spirit Fist", "Send Spirit energy like a fist to the targets face ",
        2,1, 15, 70,
        new Dictionary<string, int>
            {
                { "Damage", 7 }
            }),
        new Skills("Healing Charkra", "Ancient Technique to heal oneself using oneself",
        1,3, 20, 100,
        new Dictionary<string, int>
            {
                { "Damage", 15 }
            }),

    };
    }

}
