using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenu;

    // Update is called once per frame
    // Every Update call, determine if the 'p' button is pressed
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) {
            if (isPaused) {
                resume();
            } else {
                pause();
            }
        }
    }

    // continues gameplay
    void resume() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    // halts gameplay
    void pause() {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    // sends player to menu screen
    public void loadMenu() {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
        isPaused = false;
        ScoreScript.score = 0;
    }

    // closes application
    public void quitGame() {
        Application.Quit();
    }
}
