using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(endGame());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator endGame()
    {

        yield return new WaitForSeconds(2);
        gameOverUI.SetActive(true);

    }
}
