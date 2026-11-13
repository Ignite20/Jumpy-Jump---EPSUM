using System;
using UnityEngine;

public class StatsMenuController : MonoBehaviour {


	public event EventHandler OnStatsExit;
	public event EventHandler OnStatsCleared;

	public void OnStatsClear() {
		Debug.Log("Stats Cleared!");
		OnStatsCleared?.Invoke(this, EventArgs.Empty);
	}

	public void OnExitStats() {
		Debug.Log("Close Stats Clicked!");
		OnStatsExit?.Invoke(this, EventArgs.Empty);
	}
}
