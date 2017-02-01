using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public int score;					// The player's score.


	public GameObject Hero;	// Reference to the player control script.


	void Awake ()
	{
		// Setting up the reference.
		//playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();

	}


	void Update ()
	{
//		score =  Hero.GetComponent<Movement>().HP;
		// Set the score text.
//		GetComponent<Text>().text = "Score: " + Hero.GetComponent<Movement>().HP;


		// If the score has changed...
		//if(previousScore != score)
			// ... play a taunt.
			//playerControl.StartCoroutine(playerControl.Taunt());

		// Set the previous score to this frame's score.
		//previousScore = score;
	}

}
