﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class ActionsPause : MonoBehaviour {
    private Stage2Orchestrator _orchestrator;

    // Use this for initialization
    void Start () {
        _orchestrator = GameObject.Find("Orchestrator")
                        .GetComponent<Stage2Orchestrator>();
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Resume() {
        _orchestrator.ResumeGame();
    }

    public void ReturnToScreenTitle() {
        SceneManager.LoadScene("ScreenTitle");
    }

    public void GoToSettings() {
        _orchestrator.SettingsMenu.SetActive(true);
        _orchestrator.PauseMenu.SetActive(false);
    }

    public void ExitGame() {
        Application.Quit();
    }
}
