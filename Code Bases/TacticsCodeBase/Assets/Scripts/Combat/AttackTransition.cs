using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackTransition : MonoBehaviour
{
    public void toStrike()
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
        attackButton.GetComponent<Image>().enabled = false;
        attackText.GetComponent<Text>().enabled = false;
        defendButton.GetComponent<Image>().enabled = false;
        defendText.GetComponent<Text>().enabled = false;
        skill1Button.GetComponent<Image>().enabled = false;
        skill2Button.GetComponent<Image>().enabled = false;
        skill3Button.GetComponent<Image>().enabled = false;
        skill1Text.GetComponent<Text>().enabled = false;
        skill2Text.GetComponent<Text>().enabled = false;
        skill3Text.GetComponent<Text>().enabled = false;



		Image[] skill1Images = skill1Button.GetComponentsInChildren<Image>();
		Image[] skill2Images = skill2Button.GetComponentsInChildren<Image>();
		Image[] skill3Images = skill3Button.GetComponentsInChildren<Image>();



		//skill1DescImage.GetComponent<Image>().enabled = true;


		skill1Images[1].enabled = false;
		skill2Images[1].enabled = false;
		skill3Images[1].enabled = false;


		Text skill1DescText = skill1Images[1].gameObject.GetComponentInChildren<Text>();
		Text skill2DescText = skill2Images[1].gameObject.GetComponentInChildren<Text>();
		Text skill3DescText = skill3Images[1].gameObject.GetComponentInChildren<Text>();

		

		skill1DescText.enabled = false;
		skill2DescText.enabled = false;
		skill3DescText.enabled = false;



		var curObject = FindObjectsOfType<Attack>();
        foreach (var x in curObject)
        {
            if(x.GetComponent<Attack>().enabled)
            {
                x.GetComponent<Strike>().enabled = true;
                x.GetComponent<Attack>().enabled = false;
                break;
            }
        }
    }
}
