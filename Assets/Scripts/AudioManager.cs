using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour {

	public Sound[] sounds;

	public static AudioManager instance;

	private Sound currentSong;

	// Use this for initialization
	void Awake () {

		if (instance == null) {
			instance = this;
		} else {
			Destroy (gameObject);
			return;
		}
		DontDestroyOnLoad (gameObject);


		foreach (Sound s in sounds) 
		{
			s.source = gameObject.AddComponent<AudioSource> ();
			s.source.clip = s.clip;

			s.source.volume = s.vol;
			s.source.pitch = s.pitch;
			s.source.loop = s.loop;
		}
	}



	public void Play (string name)
	{
		Sound s = Array.Find (sounds, sound => sound.name == name);
		if (s == null) 
		{
			Debug.LogWarning ("Song with " + name + " not found!");
			return;
		}
		s.source.Play ();
		currentSong = s;
	}

	void Start ()
	{
		SongSelect ();
	}

	void SongSelect ()
	{
		System.Random rnd = new System.Random();
		int num = rnd.Next (1, 4);
		if(num == 1)
		{
			Play("Track01");
		}

		if(num == 2)
		{
			Play("Track02");
		}

		if(num == 3)
		{
			Play("Track03");
		}
			
	}

	void Update ()
	{
		if (currentSong.source.isPlaying == false) 
		{
			SongSelect ();
		}
		
	}
}
