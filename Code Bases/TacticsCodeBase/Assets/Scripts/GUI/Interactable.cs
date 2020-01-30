using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
	public GameObject battleStatBlock;
	bool currentlyVisable = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void ChangeActive()
	{
		if (currentlyVisable)
		{
			currentlyVisable = !currentlyVisable;
			battleStatBlock.SetActive(currentlyVisable);
		}
		else
		{
			currentlyVisable = !currentlyVisable;
			battleStatBlock.SetActive(currentlyVisable);
		}
	}
}
