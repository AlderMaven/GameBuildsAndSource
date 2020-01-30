using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRotationToCamera : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject camera;
	Vector3 rotationY;

	Transform cameraTransform;
	Transform ownRotation;
    void Start()
    {
		cameraTransform = camera.GetComponent<Transform>();
		ownRotation = gameObject.GetComponent<Transform>();
		rotationY = cameraTransform.rotation.eulerAngles;
		rotationY.x = 0;
		rotationY.z = 0;
		ownRotation.transform.rotation = Quaternion.Euler(rotationY);
    }

    // Update is called once per frame
    void Update()
    {
		rotationY = cameraTransform.rotation.eulerAngles;
		rotationY.x = 0;
		rotationY.z = 0;
		ownRotation.transform.rotation = Quaternion.Euler(rotationY);
	}
}
