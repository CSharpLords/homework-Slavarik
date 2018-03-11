using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
	public Button startButton;
	public Button creditsButton;
	public Button exitButton;

	void LoadGame() {
		SceneManager.LoadScene("Football2");
	}
	void ExitGame() {
		Application.Quit();
	}

	void CreditsGame() {
		SceneManager.LoadScene("Credits");
	}

	void Start () {
		startButton.onClick.AddListener(LoadGame);
		exitButton.onClick.AddListener(ExitGame);
		creditsButton.onClick.AddListener (CreditsGame);
	}
	

	void Update () {
		
	}
}
