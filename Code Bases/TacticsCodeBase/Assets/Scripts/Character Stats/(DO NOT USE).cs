using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterStats2 : MonoBehaviour
{
    //public BaseStat[] stats = new BaseStat[8];
    public CharacterTemplate stats = new CharacterTemplate();
    public Monk monk = new Monk();
    public Weapon weapons ;
    public Armor armor;
    public InventoryDatabase Database;
    public Skills skill_1;
    void Start()
    {
        stats.Name = "Eggplant";
        stats.HealthPoints = monk.Strength;
        stats.ManaPoints = 100;
        stats.Level = 1;
        stats.Experience = 0;
        stats.Mastery = 1;
        stats.Strength = 8;
        stats.Defense = 4;
        stats.Magical = 11; 
        stats.MagDefense = 3;
        stats.Speed = 5;
        stats.Luck = 5;
        /*stats[0] = new BaseStat(4, "Strength", "Character Physical Power");
        stats[1] = new BaseStat(100, "HP", "Health of Player");
        stats[2] = new BaseStat(1, "Mastery", "Proficency in Class");
        stats[3] = new BaseStat(8, "Strength", "Character Physical Attack");
        stats[4] = new BaseStat(4, "Defense", "Character Physical Defense");
        stats[5] = new BaseStat(11, "Magic", "Character Magical Power");
        stats[6] = new BaseStat(3, "MagDefense", "Character Magical Defense");
        stats[7] = new BaseStat(2, "Speed", "Distance Character can travel");
        stats[3].AddStatBonus(new StatBonus(5));
        Debug.Log(stats[3].GetCalcStatValue());*/


        stats.CurrentClass = monk.monkClass();
        stats.currentClassLvlupPoints = monk.GetLvlUpPoints();
        weapons = Database.GetWeapon(410);
        int statsmod2 = weapons.statModifier["weaponDamage"];
        Debug.Log(statsmod2);
        armor = Database.GetArmor(410);
        skill_1 = monk.skills[0];
        Debug.Log(skill_1);

    }
    /* public string Name { get; set; }
    //lvl up arrar[0]
    public int HeathPoints { get; set; }
    //lvl up arrar[1]
    public int ManaPoints { get; set; }
    // the lvl of the char
    public int Level { get; set; }
    // the amount of exp the char gains 0-100
    public int Experience { get; set; }
    // the amount of job master the char has 0-800
    // -- idea-- show progress based on the low 2 digits aka mod 100
    //-- and the high digit to show lvl of mastery
    public int Mastery { get; set; }
    //lvl up arrar[2]
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

    public Weapon curWeapon { get; set; }

    public Armor curArmor { get; set; }*/

}
