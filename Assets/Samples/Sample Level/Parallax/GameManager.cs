using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject startUI;
    public GameObject gameplayUI;
    public GameObject endUI;

    private bool gameStarted = false;
    private bool gameEnded = false;

    void Start()
    {
        ShowStartScreen();
    }

    public void StartGame()
    {
        gameStarted = true;
        startUI.SetActive(false);
        gameplayUI.SetActive(true);
        Time.timeScale = 1f; // Resume game
    }

    public void EndGame()
    {
        gameEnded = true;
        gameplayUI.SetActive(false);
        endUI.SetActive(true);
        Time.timeScale = 0f; // Pause game
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void ShowStartScreen()
    {
        Time.timeScale = 0f; // Pause the game initially
        startUI.SetActive(true);
        gameplayUI.SetActive(false);
        endUI.SetActive(false);
    }
}
