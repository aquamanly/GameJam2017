using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Nextlvl : MonoBehaviour {

	public Button newGame;
	public Scene nextLvl;
	public string lvlName;

	// Use this for initialization
	void Start () {
		Button btn =  newGame.GetComponent<Button> ();

		btn.onClick.AddListener (LoadSCene);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LoadSCene(){
		SceneManager.LoadScene (lvlName, LoadSceneMode.Single);

	}
}
