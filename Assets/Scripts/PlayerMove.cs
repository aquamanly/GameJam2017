using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public SoundManager soundManager;

	public string xaxis;
	public string yaxis;
	public string itemUse;

	//public string item;

	public float playerSpeed;

	public float sendingRate = 10f;
	public float rateBoost;
	public float boostDuration;

	public GameObject range;
	public float rangeBoost;
	public float rangeDuration;

	public float hotspots;
	public GameObject activeHotspot;

	public Vector2 direction;

	private Rigidbody2D rb2D;


	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D>();
		soundManager = FindObjectOfType<SoundManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		direction.x = Input.GetAxisRaw (xaxis);
		direction.y = Input.GetAxisRaw (yaxis);

		if (hotspots > 0 && Input.GetButtonDown (itemUse)) {

			hotspots -= 1;
			soundManager.PlayHotspot ();
			Instantiate (activeHotspot, new Vector3 (transform.position.x, transform.position.y, 0), Quaternion.identity);

		}

		float directionX = direction.x;
		float directionY = direction.y;

		if (directionX < 0 && directionY == 0) {

			transform.rotation = Quaternion.Euler (0, 0, -90);
		
		}

		if (directionX > 0 && directionY == 0) {

			transform.rotation = Quaternion.Euler (0, 0, 90);

		}

		if (directionX == 0 && directionY < 0) {

			transform.rotation = Quaternion.Euler (0, 0, 0);

		}

		if (directionX == 0 && directionY > 0) {

			transform.rotation = Quaternion.Euler (0, 0, 180);

		}


		//==========================

		if (directionX < 0 && directionY < 0) {

			transform.rotation = Quaternion.Euler (0, 0, -45);

		}

		if (directionX > 0 && directionY < 0) {

			transform.rotation = Quaternion.Euler (0, 0, 45);

		}

		if (directionX < 0 && directionY > 0) {

			transform.rotation = Quaternion.Euler (0, 0, -135);

		}

		if (directionX > 0 && directionY > 0) {

			transform.rotation = Quaternion.Euler (0, 0, 135);

		}

	}

	void FixedUpdate(){
		
		rb2D.velocity = new Vector2(direction.x * playerSpeed, direction.y * playerSpeed);
}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Speed"){
			soundManager.PlaySpeedUp ();
			sendingRate = sendingRate + rateBoost;
			Destroy (other.gameObject);
			StartCoroutine (TimedSpeed ());
		}

		if (other.tag == "RangeItem"){
			soundManager.PlayRange ();
			Destroy (other.gameObject);
			if (range.GetComponent<ExpandShrink> ().on == true) {
				range.transform.localScale += new Vector3 (rangeBoost, rangeBoost, 0);
				StartCoroutine (TimedRange ());
			}
		}

		if (other.tag == "Hotspot"){
			soundManager.PlayHotspot ();
			hotspots += 1;
			Destroy (other.gameObject);
		}

	}

	IEnumerator TimedSpeed(){
		yield return new WaitForSeconds (boostDuration);
		sendingRate = sendingRate - rateBoost;

	}

	IEnumerator TimedRange(){
		yield return new WaitForSeconds (rangeDuration);
		range.transform.localScale -= new Vector3 (rangeBoost, rangeBoost, 0);

	}
		
}
