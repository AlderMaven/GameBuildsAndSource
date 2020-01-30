using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PartyDestoryer : MonoBehaviour
{
	// Start is called before the first frame update
	Dead[] partyDeathStatuses;
	bool partyAlive = false;
	public string DesiredNextLevel;

    void Start()
    {
		partyDeathStatuses = gameObject.GetComponentsInChildren<Dead>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach(Dead deathStatus in partyDeathStatuses)
		{
			if (deathStatus.enabled == false)
			{
				partyAlive = true;
			}
		}
		if (!partyAlive)
		{
			SceneManager.LoadScene(DesiredNextLevel);
		}
		partyAlive = false;

    }
}
