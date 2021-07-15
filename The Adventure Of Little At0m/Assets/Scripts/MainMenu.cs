using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public bool gameIsPaused = false;
    public bool toggle = true;

    public GameObject pauseMenuUI;
    public GameObject winMenuUI;
    public GameObject loseMenuUI;

    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseMenuUI.SetActive(false);
        gameIsPaused = false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        gameIsPaused = true;
        Time.timeScale = 0;
    }
    public void MainScreen()
    {
        Destroy(GameObject.FindGameObjectWithTag("Music"));
        Time.timeScale = 1;
        SceneManager.LoadScene(1);

    }
    public void Win()
    {
        winMenuUI.SetActive(true);
        Time.timeScale = 0;
    }
    public void Lose()
    {
        loseMenuUI.SetActive(true);
        Time.timeScale = 0;
    }
    public void Info()
    {
        Debug.Log("Info");
    }
    public void Mute()
    {
        {
            toggle = !toggle;

            if (toggle)
                AudioListener.volume = 1f;

            else
                AudioListener.volume = 0f;
        }
    }
    public void ReplayVideo()
    {
        Destroy(GameObject.FindGameObjectWithTag("Music"));
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    
}
