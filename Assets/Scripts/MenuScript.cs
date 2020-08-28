using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject Menu;
    public GameObject GameOverMenu;
    public bool GameIsPaused;
    public GameObject ToggleSound;
    public static bool GameIsOver;
    private bool GameReplayed;
    // Start is called before the first frame update
    
    void Start()
    {        
        Time.timeScale = 0f;
        Menu.SetActive(true);
        GameOverMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!GameIsPaused)
            {
                Paused();
            }
        }
        GameIsOver = TargetDestroy.IsGameOver;
        if (GameIsOver)
        {
            Time.timeScale = 0f;
            Menu.SetActive(false);
            GameOverMenu.SetActive(true);
        }
    }
    public void PlayButton()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void ReplayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameOverMenu.SetActive(false);
        Menu.SetActive(false);
        GameReplayed = true;
    }
   
    void Paused()
    {
        Menu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void SoundToggle()
    {
         // Sound On Off will be add here
    }
    public void PlayAgain()
    {

    }
}
