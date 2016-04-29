using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayScores : MonoBehaviour {

	public Text level1, level2, level3;
	private GameObject scoreKeeper;

	// Use this for initialization
	void Start () {
		scoreKeeper = GameObject.Find ("ScoreKeeper");
		level1.text = "Level 1: " + scoreKeeper.GetComponent<KeepScore> ().GetLevelScore (0);
		level2.text = "Level 2: " + scoreKeeper.GetComponent<KeepScore> ().GetLevelScore (1);
		level3.text = "Level 3: " + scoreKeeper.GetComponent<KeepScore> ().GetLevelScore (2);

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			Application.Quit ();
	}
}
