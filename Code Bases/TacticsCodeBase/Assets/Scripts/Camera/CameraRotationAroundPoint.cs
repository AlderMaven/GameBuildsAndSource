using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraRotationAroundPoint : MonoBehaviour
{
	Rigidbody thisBody;
	public float MAX_VELOCITY = 40.0f;
	public float DELTA_VELOCITY = 10;
	Vector3 XVelocityVector;
    // Start is called before the first frame update
    void Start()
    {
		thisBody = gameObject.GetComponent<Rigidbody>();
		XVelocityVector = new Vector3(DELTA_VELOCITY, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			if (Math.Abs(thisBody.velocity.x)<MAX_VELOCITY) {
				thisBody.AddForce(-XVelocityVector);
			}
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			if (Math.Abs(thisBody.velocity.x) < MAX_VELOCITY)
			{
				thisBody.AddForce(XVelocityVector);
			}
		}
		if(!(Input.GetKey(KeyCode.LeftArrow)) && !(Input.GetKey(KeyCode.RightArrow)))
		{
			thisBody.AddForce(-(thisBody.velocity));
		}
    }
}
