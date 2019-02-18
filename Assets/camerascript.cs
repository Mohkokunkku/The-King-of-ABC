using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour {


	public Transform target;

	
	// Update is called once per frame
	void LateUpdate () 
	{
		transform.position = new Vector2(target.position.x, target.position.y);	
	}

	
}
