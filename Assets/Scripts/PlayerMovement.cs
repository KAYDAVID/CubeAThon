using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public Material M;

	public float forwardForce = 2000f;

	public float sidewaysForce = 500f;

	void Start ()
	{
		//forwardForce = PlayerPrefs.GetFloat ("Speed");
		GetColor ();

	}
	// Update is called once per frame
	void FixedUpdate () 
	{
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);	

	}

	void Update ()
	{
		if( Input.GetKey("d") )
		{
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if( Input.GetKey("a") )
		{
			rb.AddForce (-1 * sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if(rb.position.y < -7f)
		{
			FindObjectOfType<GManager> ().EndGame ();
		}

	}
		
	void GetColor ()
	{
		if(PlayerPrefs.GetInt("Color") == 1)
		{
			M.color = Color.red;
		}

		if(PlayerPrefs.GetInt("Color") == 2)
		{
			M.color = Color.blue;
		}

		if(PlayerPrefs.GetInt("Color") == 3)
		{
			M.color = Color.green;
		}
	}
}
