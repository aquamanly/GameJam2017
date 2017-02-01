using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandShrink : MonoBehaviour {

	public bool on;
	public float maxSize;
	public float changeRate = 10f;

	// Use this for initialization
	void Start () {
		on = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (on && transform.localScale.x < maxSize) {
		 
			transform.localScale += new Vector3 (0.01f * changeRate, 0.01f * changeRate, 0);
		
		} 

		else if (!on && transform.localScale.x >= 0) {

			transform.localScale -= new Vector3 (0.01f * changeRate, 0.01f * changeRate, 0);

		}

		if (transform.localScale.x < 0) {
			transform.localScale = new Vector3 (0, 0, 0);
		}
	}
}
