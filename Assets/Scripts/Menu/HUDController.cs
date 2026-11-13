using System;
using UnityEngine;

public class HUDController : MonoBehaviour {

	public event EventHandler OnPauseClicked;


	public void OnPlayerPaused() {
		Debug.Log("Game Paused");
		OnPauseClicked?.Invoke(this, EventArgs.Empty);
	}
}
