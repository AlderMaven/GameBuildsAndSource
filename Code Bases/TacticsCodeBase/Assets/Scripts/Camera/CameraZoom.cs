using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
	// Start is called before the first frame update
	public float closestCameraPosition = 5.0f;
	public float farthestCameraPosition = 30.0f;
	public float speedOfZoom = 1.0f;
	HingeJoint camerasHingeJoint;

	private void Start()
	{
		camerasHingeJoint = gameObject.GetComponent<HingeJoint>();
	}



	void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			
			if (camerasHingeJoint.anchor.z > closestCameraPosition)
			{
				Debug.Log("Entered Up");
				camerasHingeJoint.anchor.Set(camerasHingeJoint.anchor.x, camerasHingeJoint.anchor.y, camerasHingeJoint.anchor.z - speedOfZoom);

			}
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			
			if (camerasHingeJoint.anchor.z < farthestCameraPosition)
			{
				Debug.Log("Entered Down");
				camerasHingeJoint.anchor.Set(10.0f, 20.0f, 10.0f);

			}
		}
		
	}
}
