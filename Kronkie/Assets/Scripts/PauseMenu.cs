using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;

    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (isPaused)
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                LoadNextScene();
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                Resume();
            }
        }
    }

    void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f; // Pause the game
        pauseMenuUI.SetActive(true);
    }

    public void Resume()
    {
        isPaused = false;
        Time.timeScale = 1f; // Resume the game
        pauseMenuUI.SetActive(false);
    }

    public void LoadNextScene()
    {
        Resume(); // Resume the game before loading the next scene

        // Placeholder logic for changing the scene
        // Replace "YourNextSceneName" with the actual name of your next scene
        SceneManager.LoadScene("MainMenu");
    }
}
