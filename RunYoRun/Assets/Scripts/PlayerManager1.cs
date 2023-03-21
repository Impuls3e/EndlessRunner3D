using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager1 : MonoBehaviour
{
    public static int NumberOfCoins;
    public Text CoinsText;
    public static int TotalCoins;
    
    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        CoinsText.text = "" + NumberOfCoins;
        PlayerPrefs.SetInt("NumberOfCoins",NumberOfCoins);
        TotalCoins += NumberOfCoins;


    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("TotalCoins", TotalCoins);
        PlayerPrefs.Save();
    }
}
