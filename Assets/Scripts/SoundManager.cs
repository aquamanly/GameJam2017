using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	private AudioSource audioSource;
	public AudioClip plug, speedUp, hotspot, range;

	// Use this for initialization
	void Start () {
		
		audioSource = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayPlug() 
	{
		audioSource.PlayOneShot(plug);

	}
	public void PlaySpeedUp()
	{
		audioSource.PlayOneShot(speedUp);
	}

	public void PlayHotspot()
	{
		audioSource.PlayOneShot(hotspot);
	}

	public void PlayRange()
	{
		audioSource.PlayOneShot(range);
	}
		
}
