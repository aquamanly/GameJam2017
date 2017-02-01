using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroy : MonoBehaviour {

	public float duration;
	public GameObject child;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (child.GetComponent<ExpandShrink> ().on == true) {

			StartCoroutine (waitToShrink ());
		}

		if (child.transform.localScale.x <= 0) {

			Destroy (gameObject);
		}

	}

	IEnumerator waitToShrink (){

		yield return new WaitForSeconds (duration);

		child.GetComponent<ExpandShrink> ().on = false;
	}
}
