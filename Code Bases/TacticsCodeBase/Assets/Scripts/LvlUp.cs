using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlUp : CharacterTemplate
{
    public GameObject[] CHARClass;
    public void LevelUP()
    {
        if (Experience > 100)
        {
            Level++;
            Experience -= 100;

            completedAttClass[ (int)CurrentClass]++;// at level up gets the current class number and then adds it to the completed classes
            // to help keep up with the prereqs
            HealthPoints += currentClassLvlupPoints[0];
            ManaPoints += currentClassLvlupPoints[1];
            Mastery += currentClassLvlupPoints[2];
            Strength += currentClassLvlupPoints[3];
            Defense += currentClassLvlupPoints[4];
            Magical += currentClassLvlupPoints[5];
            MagDefense += currentClassLvlupPoints[6];
            Speed += currentClassLvlupPoints[7];
            Luck += currentClassLvlupPoints[8];
        }
    }


}
