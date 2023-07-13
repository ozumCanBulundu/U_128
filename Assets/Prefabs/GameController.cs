using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject menuCanvas;

    void Awake()
    {
        menuCanvas.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("esc");
            OpenCloseMenu();
        }
    }

    public void OpenCloseMenu()
    {
        if (menuCanvas.activeSelf == true)
        {
            menuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }
        else if (menuCanvas.activeSelf == false)
        {
            menuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
            return;
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0); //main menu indexi girildi index değiştirilince değer değiştirilmeli
    }
    public void QuitGame()
    {
        Debug.Log("quitting...");
        //Application.Quit();
    }
}
