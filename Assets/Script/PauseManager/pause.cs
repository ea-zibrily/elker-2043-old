using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject homeButton;
    public GameObject clueButton;
    public GameObject playButton;

    public void goPause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void goHome()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }

    public void goClue()
    {
        clueButton.SetActive(true);
    }

    public void goPlay()
    {
        pausePanel.SetActive(false);
        clueButton.SetActive(false);
        Time.timeScale = 1;
    }

}
