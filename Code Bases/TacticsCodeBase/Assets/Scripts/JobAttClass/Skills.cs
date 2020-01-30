using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills 
{
    public Dictionary<string, int> statModifier = new Dictionary<string, int>(); // gives element and damage amount
    // helps line up with weapons and armor

    /*public enum SkillType 
    {
        Self = 1
        SelectedEnemy = 2
        SelectedArea = 3
        AreaAroundSelf = 4
    }*/

    /*public enum DamageType 
    {
        Physical = 1, // blocked by defense
        Magical = 2, // blocked by MagDefense
        Absoulute = 3 // ignore defense and mag defense, this is for healing
    }*/

    public string name;
    public string Description;
    public int ManaCost;
    public int accuracy;
    public int SkillType;
    public int DamageType;


    
    public Skills(string Name, string Description, int SkillType, int DamageType, int ManaCost, int Accuracy,
        Dictionary<string, int> statModifier)

    {
        this.name = Name;
        this.Description = Description;
        this.ManaCost = ManaCost;
        this.accuracy = Accuracy;
        this.statModifier = statModifier;
        this.SkillType = SkillType;
        this.DamageType = DamageType;

    }

}
