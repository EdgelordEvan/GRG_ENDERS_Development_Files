using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour {

    public bool gameIsPaused;
    public GameObject pauseMenuUI;


	// Update is called once per frame
	void Update () {
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
    public void Resume()
    {
        
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        Debug.Log("Resume");
    }
    void Pause()
    {
  
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void LoadMenu()
    {
        // Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
    }

    public void QuitMenu()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
