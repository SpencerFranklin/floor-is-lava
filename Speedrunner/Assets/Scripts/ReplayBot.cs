using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class ReplayBot : MonoBehaviour {

	public int level;
	private GameObject scoreKeep;
	private Queue positions;

	// Use this for initialization
	void Start () {
		scoreKeep = GameObject.Find ("ScoreKeeper");
		positions = (Queue)scoreKeep.GetComponent<KeepScore> ().GetReplay (level - 1);
	}

	// Update is called once per frame
	void Update () {
		if (positions.Count > 0)
			transform.position = (Vector3)positions.Dequeue ();
		else {
			SceneManager.LoadScene ("End");
		}
		if (Input.GetKeyDown (KeyCode.Escape))
			Application.Quit ();
	}


}
