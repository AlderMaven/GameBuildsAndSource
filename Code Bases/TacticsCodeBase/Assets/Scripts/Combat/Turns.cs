using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;


public class Turns : MonoBehaviour
{
    public GameObject activePlayer;
    public int completeTurn = 0;
    public List<GameObject> sortedTurn;
    public static bool turnTimer = true;
    public static bool endTurn = true;
    int allyCount;
    int enemyCount;

	public void NewTurnOrder()
	{
		//List<int> turnList = new List<int>();
		sortedTurn = new List<GameObject>();
		GameObject[] players = GameObject.FindGameObjectsWithTag("Player"); //Getting the players and npcs
		GameObject[] npcs = GameObject.FindGameObjectsWithTag("NPC");

		GameObject[] characters = new GameObject[players.Length + npcs.Length];

		//Combining the players and npcs into a single 'character' list
		int count = 0;
		foreach (GameObject player in players)
		{
			characters[count] = player;
			count++;
		}

		foreach (GameObject npc in npcs)
		{
			characters[count] = npc;
			count++;
		}

		if (characters != null)
		{
			foreach (GameObject x in characters)
			{
				if (x.GetComponent<CharacterStats>() != null)
				{
					int speed1 = x.GetComponent<CharacterStats>().Speed;
					if (sortedTurn.Count == 0)
					{
						sortedTurn.Add(x);
						//turnList.Add(speed1);
					}
					else
					{
						foreach (GameObject z in sortedTurn)
						{
							if (z.GetComponent<CharacterStats>().Speed < speed1 && !sortedTurn.Contains(x))
							{
								Debug.Log(x);
								sortedTurn.Insert(sortedTurn.IndexOf(z), x);
								speed1 = -1;
								break;
							}
						}
						if (speed1 != -1 && !sortedTurn.Contains(x))
						{
							Debug.Log(x);
							sortedTurn.Add(x);
							//turnList.Add(speed1);
						}
					}

				}
			}
		}
		foreach (GameObject z in sortedTurn)
		{
			if (z.GetComponent<CharacterStats>().team == 1)
			{
				allyCount++;
			}
			else
			{
				enemyCount++;
			}
		}
	}
    void Start()
    {
		NewTurnOrder();
    }



    //Update is called once per frame
    void Update()
    {
        if(turnTimer)
        {
            if (completeTurn == sortedTurn.Count)
            {
                completeTurn = 0;
            }
            activePlayer = sortedTurn[completeTurn];
            Debug.Log(activePlayer.GetComponent<CharacterStats>().Name);
            turnTimer = false;
            if(activePlayer.GetComponent<CharacterStats>().HealthPoints > 0)
            {
                activePlayer.GetComponent<Idle>().enabled = true;
            }
            else if(activePlayer.GetComponent<CharacterStats>().HealthPoints <= 0)
            {
                endTurn = false;
                activePlayer.GetComponent<Standby>().enabled = false;
                activePlayer.GetComponent<Dead>().enabled = true;

                if(activePlayer.GetComponent<CharacterStats>().team == 1)
                {
                    allyCount = allyCount - 1;
                    if(allyCount == 0)
                    {
                        Debug.Log("Player 1 has lost");
						GameObject party = GameObject.Find("Party");
						Destroy(party);
						SceneManager.LoadScene("GameOver");
                    }
                }
                else
                {
                    enemyCount = enemyCount - 1;
                    if (enemyCount == 0)
                    {
                        Debug.Log("Player 1 has won");
                    }
                }
            }
        }
        else if(!turnTimer && !endTurn)
        {
            Debug.Log("Turn Over");
            completeTurn++;
            turnTimer = true;
            endTurn = true;
        }
        else
        {
           
        }
    }

}
