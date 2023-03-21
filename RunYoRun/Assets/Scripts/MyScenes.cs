using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("StartScene");
        Time.timeScale = 1;
    }
    public void QuitGame()
    {

        Application.Quit();
    }
    public void MarketScene()
    {
        
        SceneManager.LoadScene("MarketScene");
        Time.timeScale = 1;

    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1;

    }
   
}
