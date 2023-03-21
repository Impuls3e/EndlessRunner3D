using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MiniMenu : MonoBehaviour
{
    public GameObject MiniMenuScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectMenu()
    {
        Time.timeScale = 0;
        
        MiniMenuScene.SetActive(true);
       

    }
    public void ResumeGame()
    {
        MiniMenuScene.SetActive(false);
        Time.timeScale = 1;
    }
    public void ReloadLevel()
    {

        SceneManager.LoadScene("StartScene");
        Time.timeScale = 1;
    }
}
