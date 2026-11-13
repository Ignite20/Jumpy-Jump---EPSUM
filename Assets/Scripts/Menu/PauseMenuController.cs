using System;
using UnityEngine;

public class PauseMenuController : MonoBehaviour {


	public event EventHandler OnRestartClicked;
	public event EventHandler OnMainMenuClicked;
	public event EventHandler OnResumeGameClicked;




	public void OnRestart() {
		Debug.Log("Game Paused");
		OnRestartClicked?.Invoke(this, EventArgs.Empty);
	}

	public void OnOpenMainMenu() {
		Debug.Log("Back to Main Menu");
		OnMainMenuClicked?.Invoke(this, EventArgs.Empty);
	}

	public void OnGameResume() {
		Debug.Log("Game Resumed!");
		OnResumeGameClicked?.Invoke(this, EventArgs.Empty);
	}

}
