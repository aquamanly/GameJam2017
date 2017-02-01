using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataRecieve : MonoBehaviour {

	public float totalEmails;
	public float downloadLevel;
	public GameObject player;
	public bool sending;

	private bool emailSent;

	public GameManager gameManager;


	// Use this for initialization
	void Start () {
		
		gameManager = FindObjectOfType <GameManager> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (totalEmails <= 0){
			//leave?
			Destroy (gameObject);
		}

		if (sending	&& downloadLevel < 100) {
			downloadLevel = Mathf.Min (downloadLevel + player.GetComponent<PlayerMove> ().sendingRate * Time.deltaTime, 100.0F);
		}

		if (downloadLevel == 100) {
			
			downloadLevel = 0;

			emailSent = true;

		}
		if (emailSent) {
			
			totalEmails -= 1;
			gameManager.sentEmails += 1;
			emailSent = false;
		}
	}

	void OnTriggerStay2D (Collider2D other){

		if (totalEmails > 0) {
			
			if (other.tag == "Range") {
				// && player.GetComponent<CablePlug> ().holdingC1 || player.GetComponent<CablePlug> ().holdingC2 || player.GetComponent<CablePlug> ().holdingC3 || player.GetComponent<CablePlug> ().holdingC4
				sending = true;
			}
		}
	}

	void OnTriggerExit2D (Collider2D other){
		if (other.tag == "Range") {
			sending = false;
		}
				
	}
		
}
