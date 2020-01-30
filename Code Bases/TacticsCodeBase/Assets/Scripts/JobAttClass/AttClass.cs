using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttClass : MonoBehaviour
{
    public CharacterTemplate stats = new CharacterTemplate();
    public void AttClassCur(int Class) {

        switch (Class) {
            case 0:
                break;
            case 1:                
                {
                Bard CurClass = new Bard();
                    Skills skill_1;
                    Skills skill_2;
                    Skills skill_3;
                    skill_1 = CurClass.skills[0];
                    skill_2 = CurClass.skills[1];
                    skill_3 = CurClass.skills[2];
                    stats.CurrentClass = CurClass.bardClass();
                    stats.currentClassLvlupPoints = CurClass.GetLvlUpPoints();
                }
                break;
            case 2:
                {
                    Fighter CurClass = new Fighter();
                    Skills skill_1;
                    Skills skill_2;
                    Skills skill_3;
                    skill_1 = CurClass.skills[0];
                    skill_2 = CurClass.skills[1];
                    skill_3 = CurClass.skills[2];
                    stats.CurrentClass = CurClass.fighterClass();
                    stats.currentClassLvlupPoints = CurClass.GetLvlUpPoints();
                }
                break;
            case 3:
                {
                    Monk CurClass = new Monk();
                    Skills skill_1;
                    Skills skill_2;
                    Skills skill_3;
                    skill_1 = CurClass.skills[0];
                    skill_2 = CurClass.skills[1];
                    skill_3 = CurClass.skills[2];
                    stats.CurrentClass = CurClass.monkClass();
                    stats.currentClassLvlupPoints = CurClass.GetLvlUpPoints();
                }
                break;
            case 4:
                {
                    Wizard CurClass = new Wizard();
                    Skills skill_1;
                    Skills skill_2;
                    Skills skill_3;
                    skill_1 = CurClass.skills[0];
                    skill_2 = CurClass.skills[1];
                    skill_3 = CurClass.skills[2];
                    stats.CurrentClass = CurClass.wizardClass();
                    stats.currentClassLvlupPoints = CurClass.GetLvlUpPoints();
                }
                break;
            case 5:
                {
                    Priest CurClass = new Priest();
                    Skills skill_1;
                    Skills skill_2;
                    Skills skill_3;
                    skill_1 = CurClass.skills[0];
                    skill_2 = CurClass.skills[1];
                    skill_3 = CurClass.skills[2];
                    stats.CurrentClass = CurClass.priestClass();
                    stats.currentClassLvlupPoints = CurClass.GetLvlUpPoints();
                }
                break;
            case 6:

                break;
            case 7:

                break;
            case 8:

                break;


        }
    
    
    
    } 
    public enum attClass
    {
        None,
        Bard,
        Fighter,
        Monk,
        Wizard,
        Priest,
        


    }

    public string attackClass = attClass.None.ToString();



}
