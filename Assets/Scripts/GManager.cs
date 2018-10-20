using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GManager : MonoBehaviour {

	bool gameHasEnded = false;

	public float delay = 2f;

	public GameObject lvlCompleteUI;

	public void EndGame ()
	{
		if(gameHasEnded == false)
		{
			gameHasEnded = true;
			PlayerPrefs.SetInt ("Lives", PlayerPrefs.GetInt ("Lives") - 1);
			Invoke("Restart", delay);
		}
	}

	void Restart ()
	{
		if (PlayerPrefs.GetInt ("Lives") <= 0) {
			SceneManager.LoadScene ("End Screen");
		} else {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}

	public void CompleteLevel ()
	{
		lvlCompleteUI.SetActive (true);
	}
}
