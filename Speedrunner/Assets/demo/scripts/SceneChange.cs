﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

	public void LoadScene(string scene) {
		SceneManager.LoadScene (scene);
	}
}
