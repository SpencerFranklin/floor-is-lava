using UnityEngine;
using System.Collections;

public class KeepScore : MonoBehaviour {

	static ArrayList scoreList;

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad (this);
		scoreList = new ArrayList { "", "", "" };
		if (FindObjectsOfType (GetType ()).Length > 1)
			Destroy (gameObject);
	}
	
	public void AddScore(int index, string f) {
		scoreList [index] = f;
	}
	public string GetLevelScore(int index) {
		return (string)scoreList [index];
	}
}
