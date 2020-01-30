using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class JobAttClass: CharacterTemplate
{
    /*
    struct Prereq
    {
        JobAttClass class;
        int masterLevel; 
    }
    */
    
    public string charAttClassName { get; set; }
    public string charAttClassDescription { get; set; }

    public int charAttClass { get; set; }

    public string charJobName { get; set; }
    public string charJobDescription { get; set; }


    /*
    public void AddPreq( System.Type classType, int level )
    {
        // add to list; 
    }

    public bool HasPrereqs( CharacterTemplate* instanceOfAChracter )
    {
        // forreach prereq
        // ...check if character has class at level required - if not, return false

        // if all pass, return true; 
    }
    */

    // this is were the job ans class are called and stored
    public enum attClass
    {
        None,
        Bard,
        Fighter,
        Monk,
        Wizard,
        Priest,
        Gunner,
        Thief,
        Archer,
        Barbarian,
        Cleric,
        Druid,
        Paladin,
        Ranger,
        Rogue,
        Sorcerer,
        Warlock,
        Knight,
        Sniper,
        Bishop,
        Assassin,
        Summoner,
        Blademaster


    }
    public enum weaponchoice {
    None,
    Dagger,
    Sword,
    Axe,
    Spear,
    Shield,
    Longsword,
    Bow,
    Gun
    }
    public enum Armorchoice { 
    None,
    HelmetLight,
    HelmetMedium,
    HelmetHeavy,
    ChestLight,
    ChestMedium,
    ChestHeavy,
    ArmsLight,
    ArmsMedium,
    ArmsHeavy,
    LegsLight,
    LegsMedium,
    LegsHeavy,
    }

   

}
