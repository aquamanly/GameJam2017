using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public float sentEmails;
	public float maxEmails;
	public bool emailMaxed;
	public Text scoreText;

	public bool timerOn;
	public float currentTime;
	public Text timeText;

	public float endDelay;
	public float winDelay;
	public string endScene;
	public string winScene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (timerOn) {
			
			currentTime -= Time.deltaTime;

		}

		if (sentEmails == maxEmails) {
			
			emailMaxed = true;

		}

		if (emailMaxed) {
			
			StartCoroutine (WaitThenWin ());
		}

		if (currentTime <= 0 && !emailMaxed) {

			StartCoroutine (WaitThenEnd ());
		}
		float remainingEmails = maxEmails - sentEmails;
		scoreText.text = remainingEmails.ToString();

		timeText.text = (currentTime / 60).ToString("00") + ":" + (currentTime % 60).ToString("00");

	}
		
	IEnumerator WaitThenEnd(){
			
		// Wait for a number of seconds.
			
		yield return new WaitForSeconds(endDelay);
			
		// Load the desired scene.
			
		SceneManager.LoadScene(endScene);

	}

	IEnumerator WaitThenWin()
	{
		// Wait for a number of seconds.
		yield return new WaitForSeconds(winDelay);


		// Load the desired scene.
		SceneManager.LoadScene(winScene);
	}
}
