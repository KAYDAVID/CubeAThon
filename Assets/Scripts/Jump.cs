using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	public Rigidbody rb;

	public float upwardForce = 100f;

	void OnTriggerEnter (Collider collisionInfo)
	{
		if (collisionInfo.tag == "Player") 
		{
			Debug.Log ("Jump");
			rb.AddForce (0, upwardForce * Time.deltaTime, 0, ForceMode.VelocityChange);
		}
	}

}
