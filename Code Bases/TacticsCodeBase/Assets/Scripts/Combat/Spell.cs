using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    void OnEnable()
    {
        Debug.Log("Now in Spell with spell " + GetComponent<CharacterStats>().usingSkill);
        
        if(GetComponent<CharacterStats>().usingSkill == 1)
        {
            if(GetComponent<CharacterStats>().skill_1.SkillType == 1)
            {
                if(GetComponent<CharacterStats>().skill_1.ManaCost <= GetComponent<CharacterStats>().ManaPoints)
                {
                    GetComponent<CharacterStats>().ManaPoints = GetComponent<CharacterStats>().ManaPoints - GetComponent<CharacterStats>().skill_1.ManaCost;
                    GetComponent<SelfTargetSpell>().enabled = true;
                }
                else
                {
                    Debug.Log("Not enough Mana");
                    GetComponent<Standby>().enabled = true;
                }
            }
            else if(GetComponent<CharacterStats>().skill_1.SkillType == 2)
            {
                if (GetComponent<CharacterStats>().skill_1.ManaCost <= GetComponent<CharacterStats>().ManaPoints)
                {
                    GetComponent<CharacterStats>().ManaPoints = GetComponent<CharacterStats>().ManaPoints - GetComponent<CharacterStats>().skill_1.ManaCost;
                    GetComponent<RangedSpell>().enabled = true;
                }
                else
                {
                    Debug.Log("Not enough Mana");
                    GetComponent<Standby>().enabled = true;
                }
            }
            else if(GetComponent<CharacterStats>().skill_1.SkillType == 4)
            {
                if (GetComponent<CharacterStats>().skill_1.ManaCost <= GetComponent<CharacterStats>().ManaPoints)
                {
                    GetComponent<CharacterStats>().ManaPoints = GetComponent<CharacterStats>().ManaPoints - GetComponent<CharacterStats>().skill_1.ManaCost;
                    //SCRIPT FOR SELF AOE SPELL
                    GetComponent<SelfAreaSpell>().enabled = true;
                }
                else
                {
                    Debug.Log("Not enough Mana");
                    GetComponent<Standby>().enabled = true;
                }
            }
        }
        else if(GetComponent<CharacterStats>().usingSkill == 2)
        {
            if (GetComponent<CharacterStats>().skill_2.SkillType == 1)
            {
                if (GetComponent<CharacterStats>().skill_2.ManaCost <= GetComponent<CharacterStats>().ManaPoints)
                {
                    GetComponent<CharacterStats>().ManaPoints = GetComponent<CharacterStats>().ManaPoints - GetComponent<CharacterStats>().skill_2.ManaCost;
                    GetComponent<SelfTargetSpell>().enabled = true;
                }
                else
                {
                    Debug.Log("Not enough Mana");
                    GetComponent<Standby>().enabled = true;
                }
            }
            else if (GetComponent<CharacterStats>().skill_2.SkillType == 2)
            {
                if (GetComponent<CharacterStats>().skill_2.ManaCost <= GetComponent<CharacterStats>().ManaPoints)
                {
                    GetComponent<CharacterStats>().ManaPoints = GetComponent<CharacterStats>().ManaPoints - GetComponent<CharacterStats>().skill_2.ManaCost;
                    GetComponent<RangedSpell>().enabled = true;
                }
                else
                {
                    Debug.Log("Not enough Mana");
                    GetComponent<Standby>().enabled = true;
                }
            }
            else if (GetComponent<CharacterStats>().skill_2.SkillType == 4)
            {
                if (GetComponent<CharacterStats>().skill_2.ManaCost <= GetComponent<CharacterStats>().ManaPoints)
                {
                    GetComponent<CharacterStats>().ManaPoints = GetComponent<CharacterStats>().ManaPoints - GetComponent<CharacterStats>().skill_2.ManaCost;
                    //SCRIPT FOR SELF AOE SPELL
                    GetComponent<SelfAreaSpell>().enabled = true;
                }
                else
                {
                    Debug.Log("Not enough Mana");
                    GetComponent<Standby>().enabled = true;
                }
            }
        }
        else if(GetComponent<CharacterStats>().usingSkill == 3)
        {
            if (GetComponent<CharacterStats>().skill_3.SkillType == 1)
            {
                if (GetComponent<CharacterStats>().skill_3.ManaCost <= GetComponent<CharacterStats>().ManaPoints)
                {
                    GetComponent<CharacterStats>().ManaPoints = GetComponent<CharacterStats>().ManaPoints - GetComponent<CharacterStats>().skill_3.ManaCost;
                    GetComponent<SelfTargetSpell>().enabled = true;
                }
                else
                {
                    Debug.Log("Not enough Mana");
                    GetComponent<Standby>().enabled = true;
                }
            }
            else if (GetComponent<CharacterStats>().skill_3.SkillType == 2)
            {
                if (GetComponent<CharacterStats>().skill_3.ManaCost <= GetComponent<CharacterStats>().ManaPoints)
                {
                    GetComponent<CharacterStats>().ManaPoints = GetComponent<CharacterStats>().ManaPoints - GetComponent<CharacterStats>().skill_2.ManaCost;
                    GetComponent<RangedSpell>().enabled = true;
                }
                else
                {
                    Debug.Log("Not enough Mana");
                    GetComponent<Standby>().enabled = true;
                }
            }
            else if (GetComponent<CharacterStats>().skill_3.SkillType == 4)
            {
                if (GetComponent<CharacterStats>().skill_3.ManaCost <= GetComponent<CharacterStats>().ManaPoints)
                {
                    GetComponent<CharacterStats>().ManaPoints = GetComponent<CharacterStats>().ManaPoints - GetComponent<CharacterStats>().skill_3.ManaCost;
                    //SCRIPT FOR SELF AOE SPELL
                    GetComponent<SelfAreaSpell>().enabled = true;
                }
                else
                {
                    Debug.Log("Not enough Mana");
                    GetComponent<Standby>().enabled = true;
                }
            }
        }

        GetComponent<Spell>().enabled = false;

    }
}
