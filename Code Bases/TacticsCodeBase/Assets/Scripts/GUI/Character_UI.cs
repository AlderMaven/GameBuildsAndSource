using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_UI : MonoBehaviour
{
	// Start is called before the first frame update
	// Start is called before the first frame update
	Text displayText;
	string displayHP = "HP: ";
    string displayStr = "Strength: ";
	string displayMP = "MP: ";
	string displayTeam = "Team: ";
	string newline = "\n";
	public int displayHPValue = 0;
    public int displayStrValue = 0;
	public int displayMPValue = 0;
	public int displayTeamValue = 0;
	
	public GameObject displayValueSource;
	CharacterStats stats;
	string name;
	void Start()
	{
		displayText = gameObject.GetComponent<Text>();
		if (displayValueSource == null)
		{
			displayValueSource = GameObject.Find("Pooka");
		}
		stats = displayValueSource.GetComponent<CharacterStats>();
		name = stats.Name;
	}

	// Update is called once per frame
	void Update()
	{

		//stats = displayValueSource.GetComponent<CharacterStats>();
		name = stats.Name;
		//In final version would want to update display value with desired info from source, ie height at position, or char HP etc.
		displayHPValue = stats.HealthPoints;
        displayStrValue = stats.Strength;
		displayMPValue = stats.ManaPoints;
		displayTeamValue = stats.team;
		displayText.text = "              "+ name + newline
			              + displayHP + displayHPValue + newline
                          + displayStr + displayStrValue + newline
			              +displayMP + displayMPValue + newline
						  +displayTeam + displayTeamValue;

	}

	public void UpdateDisplaySource()
	{
		stats = displayValueSource.GetComponent<CharacterStats>();
		name = stats.Name;
	}
}
