using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject PausePanel, inventory, tapeefects;
    // Start is called before the first frame update
    public void pausebuttonpressed()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void continuebuttonpressed()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void RestartButtonPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void ExitButtonPressed()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
