using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public GameObject taustakuva;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	//	var taustakuvapos = new Vector3(transform.position.x, transform.position.y, 0);
	
		taustakuva.transform.position = new Vector3(transform.position.x, transform.position.y, 0.1f);
	}
}
