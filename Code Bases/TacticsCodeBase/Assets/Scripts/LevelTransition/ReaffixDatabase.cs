using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReaffixDatabase : MonoBehaviour
{
	// Start is called before the first frame update
	CharacterStats[] characterStats;
	public string itemDatabaseName = "ItemDatabase";
    void Start()
    {
		characterStats = gameObject.GetComponentsInChildren<CharacterStats>();
    }

    public void FindAndUpdateWithDatabase()
	{
		
		GameObject database = GameObject.Find(itemDatabaseName);
		StartingPositions startingPositions = GameObject.Find("StartingPositions").GetComponent<StartingPositions>();
		int i = 0;
		foreach (CharacterStats stats in characterStats)
		{
			stats.Database = database.GetComponent<InventoryDatabase>();
			stats.gameObject.transform.position = startingPositions.startingPositions[i];
			i+=1;

            stats.gameObject.GetComponent<PlayerMove>().enabled = false;
            stats.gameObject.GetComponent<Idle>().enabled = false;
            stats.gameObject.GetComponent<Attacking>().enabled = false;
            stats.gameObject.GetComponent<Attack>().enabled = false;
            stats.gameObject.GetComponent<Defend>().enabled = false;
            stats.gameObject.GetComponent<Standby>().enabled = true;
        }
		gameObject.transform.position = startingPositions.startingPositions[i];
		GameObject.Find("Map").GetComponent<Turns>().NewTurnOrder();
	}
}
