using System;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {



	public event EventHandler OnPlayClick;
	public event EventHandler OnStatsClick;
	public event EventHandler OnExitClick;



	[SerializeField] private Button PlayButton;
	[SerializeField] private Button StatsButton;
	[SerializeField] private Button ExitButton;
	
	public void OnPlayClicked() {
		Debug.Log("Play clicked");
		OnPlayClick?.Invoke(this, EventArgs.Empty);
	}

	public void OnStatsClicked() {
		Debug.Log("Stats clicked");
		OnStatsClick?.Invoke(this, EventArgs.Empty);
	}

	public void OnExitClicked() {
		Debug.Log("Exit clicked");
		OnExitClick?.Invoke(this, EventArgs.Empty);
	}
}
