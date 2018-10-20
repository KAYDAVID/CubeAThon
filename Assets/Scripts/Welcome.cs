using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour {

	public void StartGame ()
	{
		PlayerPrefs.SetInt ("Lives", 3);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void GoToSettings ()
	{
		SceneManager.LoadScene ("SettingsMenu");
	}


}
