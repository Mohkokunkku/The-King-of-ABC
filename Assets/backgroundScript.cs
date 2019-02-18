using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScript : MonoBehaviour {
	public Transform target;
	// Use this for initialization
	
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
	}
}
