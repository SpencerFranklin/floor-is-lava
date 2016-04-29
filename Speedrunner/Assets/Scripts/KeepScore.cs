using UnityEngine;
using System.Collections;

public class KeepScore : MonoBehaviour {

	static ArrayList scoreList;

	void Start() {
		scoreList = new ArrayList { "", "", "" };
	}

	void Awake () {
		DontDestroyOnLoad (this);
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
