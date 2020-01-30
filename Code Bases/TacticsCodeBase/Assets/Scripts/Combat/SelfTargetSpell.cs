using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfTargetSpell : MonoBehaviour
{
    public int damage;
    public int damageType;
    public AudioClip MusicClip;

    public AudioSource MusicSource;

    // Start is called before the first frame update
    void OnEnable ()
    {
        MusicSource.clip = MusicClip;
        MusicSource.Play();
        if (GetComponent<CharacterStats>().usingSkill == 1)
        {
            damage = GetComponent<CharacterStats>().skill_1.statModifier["Damage"];
            damageType = GetComponent<CharacterStats>().skill_1.DamageType;
        }
        else if (GetComponent<CharacterStats>().usingSkill == 2)
        {
            damage = GetComponent<CharacterStats>().skill_2.statModifier["Damage"];
            damageType = GetComponent<CharacterStats>().skill_2.DamageType;
        }
        else if (GetComponent<CharacterStats>().usingSkill == 3)
        {
            damage = GetComponent<CharacterStats>().skill_3.statModifier["Damage"];
            damageType = GetComponent<CharacterStats>().skill_3.DamageType;
        }
        if(damageType == 3)
        {
            GetComponent<CharacterStats>().HealthPoints = GetComponent<CharacterStats>().HealthPoints + damage;
            GetComponent<Standby>().enabled = true;
            GetComponent<SelfTargetSpell>().enabled = false;
        }
    }

}
