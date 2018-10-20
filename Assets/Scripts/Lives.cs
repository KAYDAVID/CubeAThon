using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour {

	public Text lives;
	/*
	public static Lives instance;

	void Awake () {

		if (instance == null) {
			instance = this;
		} else {
			Destroy (gameObject);
			return;
		}
		DontDestroyOnLoad (gameObject);
	}*/
	
	// Update is called once per frame
	void Update () 
	{
		lives.text = PlayerPrefs.GetInt ("Lives").ToString ();
		//lives.text = UpdateLives ().ToString();
	}


	/*
	int UpdateLives()
	{
		if (gm.numTimesEnded == 0)
		{
			return 3;
		}

		if (gm.numTimesEnded == 1)
		{
			return 2;
		}

		if (gm.numTimesEnded == 2)
		{
			return 1;
		}

		else
		{
			return 0;
		}
	}*/
}
