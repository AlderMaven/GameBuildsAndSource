using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map2Select : MonoBehaviour
{
   public void LoadMap2()
	{
		SceneManager.LoadScene("SPMap1", LoadSceneMode.Single);
	}
}
