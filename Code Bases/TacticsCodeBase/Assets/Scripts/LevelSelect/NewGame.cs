using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
	public void LoadMap1()
	{
		SceneManager.LoadScene("Map1", LoadSceneMode.Single);
	}
}
