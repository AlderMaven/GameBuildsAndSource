using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterUICycler : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject previousUI;
	//GameObject newUI;
	GameObject parentCanvas;
	public GameObject previousCollision;
    void Start()
    {
		previousUI = GameObject.Find("StatUI");
		parentCanvas = GameObject.Find("Canvas");
    }

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(1))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{
				if(hit.collider.tag == "Player" || hit.collider.tag == "NPC")
				{
					//newUI = FindCharacterUI(hit.collider.gameObject.name);
					Debug.Log(hit.collider.gameObject.name);
					if(previousCollision == hit.collider.gameObject)
					{
						//Debug.Log(newUI + "in if");
						ToggleCharacterUI();

						
					}
					else
					{

						//previousUI = newUI;
						SwitchCharacterUI(hit.collider.gameObject);
						previousCollision = hit.collider.gameObject;
						
					}
					
				}
				else
				{
					ToggleCharacterUI();
				}
			}
		}
	}

	void ToggleCharacterUI()
	{
		if (previousUI.activeInHierarchy)
		{
			previousUI.SetActive(false);
		}
		else
		{
			previousUI.SetActive(true);
		}
		
	}

	//Have to go through all the children of the Canvas since UI can be inactive and GameObject.Find() doesn't work on inactive items
	GameObject FindCharacterUI(string hitName) 
	{
		string uiName = hitName + "UI";
		Transform[] childTransforms = parentCanvas.GetComponentsInChildren<Transform>(true);
		foreach(Transform childTransform in childTransforms)
		{
			if(childTransform.name == uiName)
			{
				return childTransform.gameObject;
			}
		}

		return null;
	}

	void SwitchCharacterUI(GameObject collision)
	{
		Character_UI[] newStatBlock = previousUI.GetComponentsInChildren<Character_UI>();
		Debug.Log(newStatBlock[0].gameObject.name);
		newStatBlock[0].displayValueSource = collision;
		newStatBlock[0].UpdateDisplaySource();
	}
}
