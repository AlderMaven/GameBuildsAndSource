using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetNextLevel : MonoBehaviour
{
	Scene scene;
	Scene nextScene;

	void Start()
	{
		scene = SceneManager.GetActiveScene();
		
	}

	void Update()
	{
		//Debug.Log(SceneManager.GetActiveScene().name);
		if (scene != SceneManager.GetActiveScene())
		{
			Debug.Log("In new scene");
			scene = SceneManager.GetActiveScene();
			gameObject.GetComponent<ReaffixDatabase>().FindAndUpdateWithDatabase();

		}
	}

}
