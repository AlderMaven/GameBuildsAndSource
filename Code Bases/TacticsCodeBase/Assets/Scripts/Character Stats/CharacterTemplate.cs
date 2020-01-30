using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTemplate
{
    public string Name { get; set; }

    
    public int HealthPoints { get; set; }//lvl up arrar[0]


    public int ManaPoints { get; set; }    //lvl up arrar[1]
    // the lvl of the char
    public int Level { get; set; }
    // the amount of exp the char gains 0-100
    public int Experience { get; set; }
    // Exp for level up
    public int JobMastery { get; set; }
    // the amount of job master the char has 0-800
    // -- idea-- show progress based on the low 2 digits aka mod 100
    //-- and the high digit to show lvl of mastery
    public int Mastery { get; set; }    //lvl up arrar[2]
 
    public int Strength { get; set; }    //lvl up arrar[3]

    public int Defense { get; set; }    //lvl up arrar[4]

    public int Magical { get; set; }    //lvl up arrar[5]

    public int MagDefense { get; set; }    //lvl up arrar[6]

    public int Speed { get; set; }    //lvl up arrar[7]

    public int Luck { get; set; }    //lvl up arrar[8]

    // --idea-- make the charTemp the super of class/job 
    public int Move { get; set; }

    public int Jump { get; set; }

    public int CurrentClass { get; set; }

    public int[] completedAttClass = new int [23];

    public int[] currentClassLvlupPoints = new int[9];

}
