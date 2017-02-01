using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectWifi : MonoBehaviour {

	public GameObject boss;
	public float wifipower;
	public GameObject connectionSymbol;
	public Sprite[] here= new Sprite[4];


	
	// Update is called once per frame
	void Update () {
		wifipower = boss.GetComponent<DataRecieve> ().totalEmails;
		if (wifipower == 3) {
			connectionSymbol.GetComponent<SpriteRenderer> ().sprite = here [0];
		} else if (wifipower==2) {
			connectionSymbol.GetComponent<SpriteRenderer> ().sprite = here[1];
		} else if (wifipower ==1) {
			connectionSymbol.GetComponent<SpriteRenderer> ().sprite = here[2];
		}
	}
}
