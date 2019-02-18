using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour {
	public float degreesPerSec = 120f; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("up")){

		
		 float rotAmount = degreesPerSec * Time.deltaTime; 
        float curRot = transform.localRotation.eulerAngles.z; 
        transform.localRotation = Quaternion.Euler(new Vector3(0,0,curRot+rotAmount));
		}

		if (Input.GetKey("down"))
		{
		float rotAmount = -degreesPerSec * Time.deltaTime; 
        float curRot = transform.localRotation.eulerAngles.z; 
        transform.localRotation = Quaternion.Euler(new Vector3(0,0,curRot+rotAmount));
		}
	}
}
