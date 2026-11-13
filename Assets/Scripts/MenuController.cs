using UnityEngine;

public class MenuController : MonoBehaviour {


	[SerializeField] private GameObject MainMenuPanel;
	[SerializeField] private GameObject PausePanel;
	[SerializeField] private GameObject GameOverPanel;
	[SerializeField] private GameObject StatsPanel;
	[SerializeField] private GameObject InGameHUD;


	private bool isPaused = true;

	private void Start() {

		InitGameState();

		MainMenuController mainMenuController = MainMenuPanel.GetComponentInChildren<MainMenuController>();
		StatsMenuController statsMenuController = StatsPanel.GetComponentInChildren<StatsMenuController>();
		PauseMenuController pauseMenuController = PausePanel.GetComponentInChildren<PauseMenuController>();
		HUDController hudController = InGameHUD.GetComponentInChildren<HUDController>();


		mainMenuController.OnPlayClick += MainMenuController_OnPlayClick;
		mainMenuController.OnStatsClick += MainMenuController_OnStatsClick;
		mainMenuController.OnExitClick += MainMenuController_OnExitClick;

		statsMenuController.OnStatsCleared += StatsMenuController_OnStatsCleared;
		statsMenuController.OnStatsExit += StatsMenuController_OnStatsExit;

		pauseMenuController.OnRestartClicked += PauseMenuController_OnRestartClicked;
		pauseMenuController.OnMainMenuClicked += PauseMenuController_OnMainMenuClicked;
		pauseMenuController.OnResumeGameClicked += PauseMenuController_OnResumeGameClicked;

		hudController.OnPauseClicked += HudController_OnPauseClicked;

	}

	private  void InitGameState() {
		MainMenuPanel.SetActive(true);

		PausePanel.SetActive(false);
		GameOverPanel.SetActive(false);
		StatsPanel.SetActive(false);
		InGameHUD.SetActive(false);
	}

	private void HudController_OnPauseClicked(object sender, System.EventArgs e) {
		Pause();
	}

	private void PauseMenuController_OnResumeGameClicked(object sender, System.EventArgs e) {
		Resume();
	}

	private void PauseMenuController_OnMainMenuClicked(object sender, System.EventArgs e) {
		InitGameState();
	}

	private void PauseMenuController_OnRestartClicked(object sender, System.EventArgs e) {
		PausePanel.SetActive(false);
	}

	private void StatsMenuController_OnStatsExit(object sender, System.EventArgs e) {
		StatsPanel.SetActive(false);
	}

	private void StatsMenuController_OnStatsCleared(object sender, System.EventArgs e) {
		//Clear Stats - Not implemented yet!
	}

	private void MainMenuController_OnExitClick(object sender, System.EventArgs e) {
		Application.Quit(-1);
	}

	private void MainMenuController_OnStatsClick(object sender, System.EventArgs e) {
		StatsPanel.SetActive(true);
	}

	private void MainMenuController_OnPlayClick(object sender, System.EventArgs e) {
		MainMenuPanel.SetActive(false);
		InGameHUD.SetActive(true);
	}

	private void Pause() {
		PausePanel.SetActive(true);
		Time.timeScale = 0;
		isPaused = true;
	}

	private void Resume() {
		PausePanel.SetActive(false);
		Time.timeScale = 1;
		isPaused = false;
	}
}