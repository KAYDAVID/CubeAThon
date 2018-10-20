using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

	public GManager gm;

	void OnTriggerEnter (Collider collisionInfo)
	{
		if (collisionInfo.tag == "Player") 
		{
			gm.CompleteLevel ();
		}
	}
}
