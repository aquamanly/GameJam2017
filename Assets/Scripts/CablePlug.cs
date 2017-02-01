using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CablePlug : MonoBehaviour {

	public SoundManager soundManager;
	public GameObject cablePrefab;
	public GameObject wallOutlet1;
	public GameObject wallOutlet2;
	public GameObject wallOutlet3;
	public GameObject wallOutlet4;
	public GameObject lastCable1;
	public GameObject lastCable2;
	public GameObject lastCable3;
	public GameObject lastCable4;
	public GameObject on1;
	public GameObject on2;
	public GameObject on3;
	public GameObject on4;
	public GameObject off1;
	public GameObject off2;
	public GameObject off3;
	public GameObject off4;
	public GameObject range;
	public float length1 = 17.43f;
	public float length2 = 15f;
	public float length3 = 17.43f;
	public float length4 = 9.208f;
	public string plugIn;

//	private bool nearOutlet1;
//	private bool nearOutlet2;
//	private bool nearOutlet3;
//	private bool nearOutlet4;
	private bool nearCable1;
	private bool nearCable2;
	private bool nearCable3;
	private bool nearCable4;

	public bool holdingC1;
	public bool holdingC2;
	public bool holdingC3;
	public bool holdingC4;

	public bool cablePlugged;

	// Use this for initialization
	void Start () {

		soundManager = FindObjectOfType <SoundManager> ();

		cablePlugged = true;
	
		holdingC1 = true;
	}
	
	// Update is called once per frame
	void Update () {

		//plugging out
		if (cablePlugged && holdingC1 && Input.GetButtonDown (plugIn)) {

			on1.SetActive (false);
			off1.SetActive (true);
			range.GetComponent<ExpandShrink> ().on = false;
			soundManager.PlayPlug ();
			cablePlugged = false;
			holdingC1 = false;
			Destroy (gameObject.GetComponent<HingeJoint2D> ());
			Destroy (gameObject.GetComponent<DistanceJoint2D> ());
			Debug.Log ("Unplugged!");
			return;
		}

		if (cablePlugged && holdingC2 && Input.GetButtonDown (plugIn)) {

			on2.SetActive (false);
			off2.SetActive (true);
			range.GetComponent<ExpandShrink> ().on = false;
			soundManager.PlayPlug ();
			cablePlugged = false;
			holdingC2 = false;
			Destroy (gameObject.GetComponent<HingeJoint2D> ());
			Destroy (gameObject.GetComponent<DistanceJoint2D> ());
			Debug.Log ("Unplugged!");
			return;
		}

		if (cablePlugged && holdingC3 && Input.GetButtonDown (plugIn)) {

			on3.SetActive (false);
			off3.SetActive (true);
			range.GetComponent<ExpandShrink> ().on = false;
			soundManager.PlayPlug ();
			cablePlugged = false;
			holdingC3 = false;
			Destroy (gameObject.GetComponent<HingeJoint2D> ());
			Destroy (gameObject.GetComponent<DistanceJoint2D> ());
			Debug.Log ("Unplugged!");
			return;
		}

		if (cablePlugged && holdingC4 && Input.GetButtonDown (plugIn)) {

			on4.SetActive (false);
			off4.SetActive (true);
			range.GetComponent<ExpandShrink> ().on = false;
			soundManager.PlayPlug ();
			cablePlugged = false;
			holdingC4 = false;
			Destroy (gameObject.GetComponent<HingeJoint2D> ());
			Destroy (gameObject.GetComponent<DistanceJoint2D> ());
			Debug.Log ("Unplugged!");
			return;
		}


//		if (cablePlugged && holdingC1 && nearOutlet1 && Input.GetButtonDown (plugIn)) {
//
//			on1.SetActive (false);
//			off1.SetActive (true);
//			range.SetActive (false);
//			soundManager.PlayPlug ();
//			cablePlugged = false;
//			holdingC1 = false;
//			Destroy (gameObject.GetComponent<HingeJoint2D>());
//			Destroy (gameObject.GetComponent<DistanceJoint2D> ());
//			wallOutlet1.AddComponent<HingeJoint2D> ();
//			wallOutlet1.GetComponent<HingeJoint2D> ().connectedBody = lastCable1.GetComponent<Rigidbody2D> ();
//			Debug.Log ("Unplugged!");
//			return;
//		}
//
//		if (cablePlugged && holdingC2 && nearOutlet2 && Input.GetButtonDown (plugIn)) {
//
//			on2.SetActive (false);
//			off2.SetActive (true);
//			range.SetActive (false);
//			soundManager.PlayPlug ();
//			cablePlugged = false;
//			holdingC2 = false;
//			Destroy (gameObject.GetComponent<HingeJoint2D>());
//			Destroy (gameObject.GetComponent<DistanceJoint2D> ());
//			wallOutlet2.AddComponent<HingeJoint2D> ();
//			wallOutlet2.GetComponent<HingeJoint2D> ().connectedBody = lastCable2.GetComponent<Rigidbody2D> ();
//			Debug.Log ("Unplugged!");
//			return;
//		}
//
//		if (cablePlugged && holdingC3 && nearOutlet3 && Input.GetButtonDown (plugIn)) {
//
//			on3.SetActive (false);
//			off3.SetActive (true);
//			range.SetActive (false);
//			soundManager.PlayPlug ();
//			cablePlugged = false;
//			holdingC3 = false;
//			Destroy (gameObject.GetComponent<HingeJoint2D>());
//			Destroy (gameObject.GetComponent<DistanceJoint2D> ());
//			wallOutlet3.AddComponent<HingeJoint2D> ();
//			wallOutlet3.GetComponent<HingeJoint2D> ().connectedBody = lastCable3.GetComponent<Rigidbody2D> ();
//			Debug.Log ("Unplugged!");
//			return;
//		}
//
//		if (cablePlugged && holdingC4 && nearOutlet4 && Input.GetButtonDown (plugIn)) {
//
//			on4.SetActive (false);
//			off4.SetActive (true);
//			range.SetActive (false);
//			soundManager.PlayPlug ();
//			cablePlugged = false;
//			holdingC4 = false;
//			Destroy (gameObject.GetComponent<HingeJoint2D>());
//			Destroy (gameObject.GetComponent<DistanceJoint2D> ());
//			wallOutlet4.AddComponent<HingeJoint2D> ();
//			wallOutlet4.GetComponent<HingeJoint2D> ().connectedBody = lastCable4.GetComponent<Rigidbody2D> ();
//			Debug.Log ("Unplugged!");
//			return;
//		}
			
		//---------------------------------------
		//plugging in


		if (!cablePlugged && nearCable1 && Input.GetButtonDown (plugIn)) {

			on1.SetActive (true);
			off1.SetActive (false);
			range.GetComponent<ExpandShrink> ().on = true;
			soundManager.PlayPlug ();
			cablePlugged = true;
			holdingC1 = true;
			Destroy (wallOutlet1.GetComponent<HingeJoint2D> ());
			gameObject.AddComponent<HingeJoint2D> ();
			gameObject.GetComponent<HingeJoint2D> ().connectedBody = lastCable1.GetComponent<Rigidbody2D> ();
			gameObject.AddComponent<DistanceJoint2D> ();
			gameObject.GetComponent<DistanceJoint2D> ().connectedBody = wallOutlet1.GetComponent<Rigidbody2D> ();
			gameObject.GetComponent<DistanceJoint2D> ().maxDistanceOnly = true;
			gameObject.GetComponent<DistanceJoint2D> ().autoConfigureDistance = false;
			gameObject.GetComponent<DistanceJoint2D> ().distance = length1;

			Debug.Log ("Plugged!");
			return;
		}

		if (!cablePlugged && nearCable2 && Input.GetButtonDown (plugIn)) {

			on2.SetActive (true);
			off2.SetActive (false);
			range.GetComponent<ExpandShrink> ().on = true;
			soundManager.PlayPlug ();
			cablePlugged = true;
			holdingC2 = true;
			Destroy (wallOutlet2.GetComponent<HingeJoint2D> ());
			gameObject.AddComponent<HingeJoint2D> ();
			gameObject.GetComponent<HingeJoint2D> ().connectedBody = lastCable2.GetComponent<Rigidbody2D> ();
			gameObject.AddComponent<DistanceJoint2D> ();
			gameObject.GetComponent<DistanceJoint2D> ().connectedBody = wallOutlet2.GetComponent<Rigidbody2D> ();
			gameObject.GetComponent<DistanceJoint2D> ().maxDistanceOnly = true;
			gameObject.GetComponent<DistanceJoint2D> ().autoConfigureDistance = false;
			gameObject.GetComponent<DistanceJoint2D> ().distance = length2;

			Debug.Log ("Plugged!");
			return;
		}

		if (!cablePlugged && nearCable3 && Input.GetButtonDown (plugIn)) {

			on3.SetActive (true);
			off3.SetActive (false);
			range.GetComponent<ExpandShrink> ().on = true;
			soundManager.PlayPlug ();
			cablePlugged = true;
			holdingC3 = true;
			Destroy (wallOutlet3.GetComponent<HingeJoint2D> ());
			gameObject.AddComponent<HingeJoint2D> ();
			gameObject.GetComponent<HingeJoint2D> ().connectedBody = lastCable3.GetComponent<Rigidbody2D> ();
			gameObject.AddComponent<DistanceJoint2D> ();
			gameObject.GetComponent<DistanceJoint2D> ().connectedBody = wallOutlet3.GetComponent<Rigidbody2D> ();
			gameObject.GetComponent<DistanceJoint2D> ().maxDistanceOnly = true;
			gameObject.GetComponent<DistanceJoint2D> ().autoConfigureDistance = false;
			gameObject.GetComponent<DistanceJoint2D> ().distance = length3;

			Debug.Log ("Plugged!");
			return;
		}

		if (!cablePlugged && nearCable4 && Input.GetButtonDown (plugIn)) {

			on4.SetActive (true);
			off4.SetActive (false);
			range.GetComponent<ExpandShrink> ().on = true;
			soundManager.PlayPlug ();
			cablePlugged = true;
			holdingC4 = true;
			Destroy (wallOutlet4.GetComponent<HingeJoint2D> ());
			gameObject.AddComponent<HingeJoint2D> ();
			gameObject.GetComponent<HingeJoint2D> ().connectedBody = lastCable4.GetComponent<Rigidbody2D> ();
			gameObject.AddComponent<DistanceJoint2D> ();
			gameObject.GetComponent<DistanceJoint2D> ().connectedBody = wallOutlet4.GetComponent<Rigidbody2D> ();
			gameObject.GetComponent<DistanceJoint2D> ().maxDistanceOnly = true;
			gameObject.GetComponent<DistanceJoint2D> ().autoConfigureDistance = false;
			gameObject.GetComponent<DistanceJoint2D> ().distance = length4;

			Debug.Log ("Plugged!");
			return;
		}
	}

	void OnTriggerEnter2D (Collider2D other){
		
//		if (other.tag == "Outlet1") {
//			nearOutlet1 = true;
//			Debug.Log ("nearoutlet!");
//		}
//		if (other.tag == "Outlet2") {
//			nearOutlet2 = true;
//			Debug.Log ("nearoutlet!");
//		}
//		if (other.tag == "Outlet3") {
//			nearOutlet3 = true;
//			Debug.Log ("nearoutlet!");
//		}
//
//		if (other.tag == "Outlet4") {
//			nearOutlet4 = true;
//			Debug.Log ("nearoutlet!");
//		}

		if (other.tag == "LastCable1") {
			nearCable1 = true;
		}

		if (other.tag == "LastCable2") {
			nearCable2 = true;
		}

		if (other.tag == "LastCable3") {
			nearCable3 = true;
		}

		if (other.tag == "LastCable4") {
			nearCable4 = true;
		}

	}

	void OnTriggerExit2D (Collider2D other){

//		if (other.tag == "Outlet1") {
//			nearOutlet1 = false;
//		}
//		if (other.tag == "Outlet2") {
//			nearOutlet2 = false;
//		}
//		if (other.tag == "Outlet3") {
//			nearOutlet3 = false;
//		}
//		if (other.tag == "Outlet4") {
//			nearOutlet4 = false;
//		}
		if (other.tag == "LastCable1") {
			nearCable1 = false;
		}

		if (other.tag == "LastCable2") {
			nearCable2 = false;
		}

		if (other.tag == "LastCable3") {
			nearCable3 = false;
		}

		if (other.tag == "LastCable4") {
			nearCable4 = false;
		}
	}

}
