using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCharacterRaycast : MonoBehaviour
{
	public string inputName = "Fire1";
	Interactable tempInteractable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown(inputName))
		{
			Ray clickRay = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit raycast;
			if(Physics.Raycast(clickRay, out raycast, Mathf.Infinity))
			{
				tempInteractable = raycast.collider.gameObject.GetComponent<Interactable>();
				if (tempInteractable.Equals(null))
				{
					//Do nothing
				}
				else
				{
					tempInteractable.ChangeActive();
				}
			}
		}
    }


}
