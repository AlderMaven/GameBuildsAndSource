using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NonInteractive_UI : MonoBehaviour
{
	// Start is called before the first frame update
	Text displayText;
	public string displayCategory = "Height: ";
	public float displayValue = 0;
    void Start()
    {
		displayText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

		if (Input.GetMouseButtonDown(1)) //RMB input
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{
				if (hit.collider.tag == "Player" || hit.collider.tag == "NPC")
				{
					displayValue = hit.transform.position.y - 1.0f;
				}
				else
				{
					displayValue = hit.transform.position.y;
				}
			}
		}
		//In final version would want to update display value with desired info from source, ie height at position, or char HP etc.
		displayText.text = displayCategory + displayValue;
		
    }
}
