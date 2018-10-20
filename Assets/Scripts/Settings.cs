using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Settings : MonoBehaviour {

	//public PlayerMovement pm;

	public Dropdown dp;
	public Dropdown dp2;

	List<string> speeds = new List<string>() { "Speed", "Normal", "Slow", "Fast"};
	List<string> colors = new List<string>() { "Color","Red", "Blue", "Green"};

	void Start()
	{
		dp.AddOptions (speeds);
		dp2.AddOptions (colors);
	}

	public void GoBack ()
	{
		SceneManager.LoadScene ("MainMenu");
	}

	public void SpeedChange (int index)
	{
		if (index == 1) 
		{
			PlayerPrefs.SetFloat ("Speed", 3000f);
		}

		if (index == 2) 
		{
			PlayerPrefs.SetFloat ("Speed", 2000f);
		}

		if (index == 3) 
		{
			PlayerPrefs.SetFloat ("Speed", 4000f);
		}
	}
		
	public void ColorChange (int index)
	{
		if (index == 1) 
		{
			PlayerPrefs.SetInt ("Color", 1);
		}

		if (index == 2) 
		{
			PlayerPrefs.SetInt ("Color", 2);
		}

		if (index == 3) 
		{
			PlayerPrefs.SetInt ("Color", 3);
		}

	}
}
