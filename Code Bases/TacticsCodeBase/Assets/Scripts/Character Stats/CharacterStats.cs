using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    private AttClass att;
    public string Name;
    public int HealthPoints;
    public int ManaPoints;
    public int Level;
    public int Experience;
    public int Mastery;
    public AttClass.attClass Class;
    public Skills skill_1;
    public Skills skill_2;
    public Skills skill_3;
    public CharacterTemplate stats = new CharacterTemplate();
    public int usingSkill;

    public InventoryDatabase Database;
    public Weapon weapons;
    public int weaponBonus;
    /*public Armor armor1;
    public Armor armor2;
    public Armor armor3;
    public Armor armor4;
    private int armor1Bonus;
    private int armor2Bonus;
    private int armor3Bonus;
    private int armor4Bonus;*/

    public int Strength;
    public int Defense;
    public int Magical;
    public int MagDefense;
    public int Speed;
    public int Range = 1;
    public int Luck;
    public int team;

    

    void Classes() {
        
        switch ((int)Class) { 
            case 1:
                att?.AttClassCur(1);
                Bard CurClass1 = new Bard();

                CurClass1.skillsList();
                skill_1 = CurClass1.skills[0];
                skill_2 = CurClass1.skills[1];
                skill_3 = CurClass1.skills[2];
                stats.CurrentClass = CurClass1.bardClass();
                stats.currentClassLvlupPoints = CurClass1.GetLvlUpPoints();
                Strength = 3;
                Defense = 5;
                Magical = 5;
                MagDefense = 7;
                Speed = 6;
                Luck = 7;

                weapons = Database.GetWeapon(110);
                weaponBonus = weapons.statModifier["weaponDamage"];

                break;
            case 2:
                att?.AttClassCur(2);
                Fighter CurClass2 = new Fighter();
                CurClass2.skillsList();
                skill_1 = CurClass2.skills[0];
                skill_2 = CurClass2.skills[1];
                skill_3 = CurClass2.skills[2];
                stats.CurrentClass = CurClass2.fighterClass();
                stats.currentClassLvlupPoints = CurClass2.GetLvlUpPoints();
                Strength = 8;
                Defense = 7;
                Magical = 4;
                MagDefense = 4;
                Speed = 5;
                Luck = 5;

                weapons = Database.GetWeapon(310);
                weaponBonus = weapons.statModifier["weaponDamage"];

                break;
            case 3:
                att?.AttClassCur(3);
                Monk CurClass3 = new Monk();
                CurClass3.skillsList();
                skill_1 = CurClass3.skills[0];
                skill_2 = CurClass3.skills[1];
                skill_3 = CurClass3.skills[2];
                stats.CurrentClass = CurClass3.monkClass();
                stats.currentClassLvlupPoints = CurClass3.GetLvlUpPoints();
                Strength = 4;
                Defense = 7;
                Magical = 4;
                MagDefense = 7;
                Speed = 5;
                Luck = 6;

                weapons = Database.GetWeapon(410);
                weaponBonus = weapons.statModifier["weaponDamage"]; 

                break;
            case 4:
                att?.AttClassCur(4);
                Wizard CurClass4 = new Wizard();
                CurClass4.skillsList();
                skill_1 = CurClass4.skills[0];
                skill_2 = CurClass4.skills[1];
                skill_3 = CurClass4.skills[2];
                stats.CurrentClass = CurClass4.wizardClass();
                stats.currentClassLvlupPoints = CurClass4.GetLvlUpPoints();
                Strength = 3;
                Defense = 4;
                Magical = 8;
                MagDefense = 8;
                Speed = 4;
                Luck = 6;

                weapons = Database.GetWeapon(110);
                weaponBonus = weapons.statModifier["weaponDamage"];

                break;
            case 5:
                att?.AttClassCur(5);
                Priest CurClass5 = new Priest();
                CurClass5.skillsList();
                skill_1 = CurClass5.skills[0];
                skill_2 = CurClass5.skills[1];
                skill_3 = CurClass5.skills[2];
                stats.CurrentClass = CurClass5.priestClass();
                stats.currentClassLvlupPoints = CurClass5.GetLvlUpPoints();
                Strength = 3;
                Defense = 4;
                Magical = 7;
                MagDefense = 8;
                Speed = 5;
                Luck = 6;

                weapons = Database.GetWeapon(410);
                weaponBonus = weapons.statModifier["weaponDamage"];

                break;

        }
        
    }

    private void Update()
    {   
        Classes();
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

    public int Jump { get; set; }*/

}
