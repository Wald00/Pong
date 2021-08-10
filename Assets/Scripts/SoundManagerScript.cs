using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

	public AudioClip bounceSound;
	public AudioSource audioSrc;


	void Start()
	{
		//bounceSound = Resources.Load<AudioClip>("bounce");

		// This gets the audio in the game scene and sets the variable to it.
		audioSrc = GetComponent<AudioSource>();
	}


	void Update()
	{

	}

	public static void PlaySound(string clip)
	{
		switch (clip)
		{
			case "bounce":
				

				break;

		}
	}
}
