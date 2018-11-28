using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GAMEOVER : MonoBehaviour {

    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

	public void EndGame()
    {
        Application.Quit();
    }
}
