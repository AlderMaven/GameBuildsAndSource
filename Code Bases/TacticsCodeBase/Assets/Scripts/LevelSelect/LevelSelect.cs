﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
   
    public void GoToLevel(string destination)
	{
		SceneManager.LoadScene(destination, LoadSceneMode.Single);
	}
}
