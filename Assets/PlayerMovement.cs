using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public float speed;  //Floating point variable to store the player's movement speed
	private int turnSpeed = 30;
	private Rigidbody2D rb2d; //Store a reference to the Rigidbody2D component required to use 2D Physics.
	Animator anim;
	bool grounded = false;
	public float jumpForce = 700f;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;

	private float direction;
	//private CircleCollider2D boxCol;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		//boxCol = GetComponent<CircleCollider2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//tsekkaa onko hahmo maassa, groundcheck tulee frameworkista
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
		//anim.SetBool("Ground", grounded);



		//Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");
		
		//Asettaa animaatiolle nopeuden
		anim.SetFloat("speed", Mathf.Abs(moveHorizontal));
        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");
		
		if (Input.GetKeyDown(KeyCode.UpArrow) && moveHorizontal > 0.2)
		{
			rb2d.AddForce(new Vector2(40, 0));
			
			Debug.Log("Pitäis keulii");
		}

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		
        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.AddForce(movement * speed);
		
		
		//vaihtaa hahmon kulkusuunnan 
		if (Input.GetKeyDown("left"))
		{
			transform.localEulerAngles = transform.eulerAngles + new Vector3(0,180,-2*transform.eulerAngles.z);
			Debug.Log(transform.eulerAngles);
		}

		if (Input.GetKeyDown("right"))
		{
			transform.localEulerAngles = transform.eulerAngles + new Vector3(0,180,-2*transform.eulerAngles.z);
			Debug.Log("nuoli oikeelle toimii");
		}
		//transform.localEulerAngles = transform.eulerAngles + new Vector3(0,180,-2*transform.eulerAngles.z);

		
	}

	void Update()
	{
		if(grounded && Input.GetKeyDown(KeyCode.Space)) //ois ilmeisesti parempi tehdä input-managerin kautta mutta kattoo joskus tosite
		{
			rb2d.AddForce(new Vector2(0, jumpForce));
		}
	}
}
