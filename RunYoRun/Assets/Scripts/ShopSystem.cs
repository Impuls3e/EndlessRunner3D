using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShopSystem : MonoBehaviour
{
    public int currenctRunnerIndex = 0;
    public GameObject[] runners;

    public CharBlueprint[] characters;
    public Button buyButton;
    public GameObject blockImage;


    // Start is called before the first frame update
    void Start()
    {
        foreach(CharBlueprint character in characters){

            if (character.price == 0)
                character.isUnlocked = true;
            else
                character.isUnlocked = PlayerPrefs.GetInt(character.name, 0)==0 ? false: true;
        }


        currenctRunnerIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);
        foreach (GameObject runner in runners)
            runner.SetActive(false);

        runners[currenctRunnerIndex].SetActive(true);

    }

    // Update is called once per frame

    void Update()
    {
        UpdateUI();
    }
    private void UpdateUI()
    {
        CharBlueprint c = characters[currenctRunnerIndex];
        if (c.isUnlocked)
        {
            blockImage.SetActive(true);
            buyButton.gameObject.SetActive(false);
        }
        else
        {
            buyButton.gameObject.SetActive(true);
            buyButton.GetComponentInChildren<Text>().text = "Buy-" + c.price;


            if (c.price < PlayerPrefs.GetInt("NumberOfCoins", 0))
            {
                buyButton.interactable = true;


            }
            else
            {
                buyButton.interactable = false;

            }
        }

    }

    public void NextButton()
    {

        runners[currenctRunnerIndex].SetActive(false);
        currenctRunnerIndex++;
        if (currenctRunnerIndex == runners.Length)
        
            currenctRunnerIndex = 0;
            runners[currenctRunnerIndex].SetActive(true);
       

        PlayerPrefs.SetInt("SelectedCharacter", currenctRunnerIndex);
        CharBlueprint c = characters[currenctRunnerIndex];
        if (!c.isUnlocked)
        {

            return;
        }

    }
    public void PreviousButton()
    {

        runners[currenctRunnerIndex].SetActive(false);
        currenctRunnerIndex--;
        if (currenctRunnerIndex == -1)

            currenctRunnerIndex = runners.Length-1;
        runners[currenctRunnerIndex].SetActive(true);
       
        PlayerPrefs.SetInt("SelectedCharacter", currenctRunnerIndex);
        CharBlueprint c = characters[currenctRunnerIndex];
        if (!c.isUnlocked)
        {

            return;
        }

    }

   

    public void UnlockCharacter()
    {
        CharBlueprint c = characters[currenctRunnerIndex];
        PlayerPrefs.SetInt(c.name, 1);

        PlayerPrefs.SetInt("SelectedCharacter", currenctRunnerIndex);
        c.isUnlocked = true;
        PlayerPrefs.SetInt("NumberOfCoins", PlayerPrefs.GetInt("NumberOfCoins", 0) - c.price);

    }
}
