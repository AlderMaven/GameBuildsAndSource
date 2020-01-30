using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTemplate
{
    //Put here as an example of enemy stats, but honestly we can just use the Character Template Page
    public string Name { get; set; }
    //lvl up arrar[0]
    public int HealthPoints { get; set; }
    //lvl up arrar[1]
    public int ManaPoints { get; set; }
    // the lvl of the char
    public int Level { get; set; }
    // the amount of exp the char gains 0-100
    public int Strength { get; set; }
    //lvl up arrar[3]
    public int Defense { get; set; }
    //lvl up arrar[4]
    public int Magical { get; set; }
    //lvl up arrar[5]
    public int MagDefense { get; set; }
    //lvl up arrar[6]
    public int Speed { get; set; }
    //lvl up arrar[7]
    public int Luck { get; set; }
    // --idea-- make the charTemp the super of class/job 
    public int Move { get; set; }

    public int Jump { get; set; }
}
