using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    private float timer2;

    void OnEnable()
    {
        Animator animator = GetComponent<Animator>();
        animator.SetInteger("Attacking", 1);

        GameObject Player = gameObject;
        Debug.Log("Now in Attack");
        if (gameObject.tag == "Player")
        {
            GameObject attackButton = GameObject.Find("Attack");
            GameObject attackText = GameObject.Find("AttackText");
            GameObject defendButton = GameObject.Find("Defend");
            GameObject defendText = GameObject.Find("DefendText");
            GameObject skill1Button = GameObject.Find("Skill 1");
            GameObject skill1Text = GameObject.Find("Skill1Text");
            GameObject skill2Button = GameObject.Find("Skill 2");
            GameObject skill2Text = GameObject.Find("Skill2Text");
            GameObject skill3Button = GameObject.Find("Skill 3");
            GameObject skill3Text = GameObject.Find("Skill3Text");
            
            attackButton.GetComponent<Image>().enabled = true;
            attackText.GetComponent<Text>().enabled = true;
            defendButton.GetComponent<Image>().enabled = true;
            defendText.GetComponent<Text>().enabled = true;
            skill1Button.GetComponent<Image>().enabled = true;
            skill2Button.GetComponent<Image>().enabled = true;
            skill3Button.GetComponent<Image>().enabled = true;
            skill1Text.GetComponent<Text>().enabled = true;
            skill2Text.GetComponent<Text>().enabled = true;
            skill3Text.GetComponent<Text>().enabled = true;




			//BBarnes
			Image[] skill1Images = skill1Button.GetComponentsInChildren<Image>();
			Image[] skill2Images = skill2Button.GetComponentsInChildren<Image>();
			Image[] skill3Images = skill3Button.GetComponentsInChildren<Image>();



			//skill1DescImage.GetComponent<Image>().enabled = true;


			skill1Images[1].enabled = true;
			skill2Images[1].enabled = true;
			skill3Images[1].enabled = true;


			Text skill1DescText = skill1Images[1].gameObject.GetComponentInChildren<Text>();
			Text skill2DescText = skill2Images[1].gameObject.GetComponentInChildren<Text>();
			Text skill3DescText = skill3Images[1].gameObject.GetComponentInChildren<Text>();

			skill1DescText.text = Player.GetComponent<CharacterStats>().skill_1.Description;
			skill2DescText.text = Player.GetComponent<CharacterStats>().skill_2.Description;
			skill3DescText.text = Player.GetComponent<CharacterStats>().skill_3.Description;

			skill1Text.GetComponent<Text>().text = Player.GetComponent<CharacterStats>().skill_1.name;
			skill2Text.GetComponent<Text>().text = Player.GetComponent<CharacterStats>().skill_2.name;
			skill3Text.GetComponent<Text>().text = Player.GetComponent<CharacterStats>().skill_3.name;

			skill1DescText.enabled = true;
			skill2DescText.enabled = true;
			skill3DescText.enabled = true;


			//Debug.Log(skill1Images[1].name);
		}
    }
}
