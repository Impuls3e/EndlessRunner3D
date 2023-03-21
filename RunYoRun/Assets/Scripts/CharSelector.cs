using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelector : MonoBehaviour
{
    public GameObject nannyDistance;
    public GameObject BettyDistance;
    public GameObject BrendaDistance;
    public GameObject KattyDistance;
    public GameObject nannyCam;
    public GameObject BettyCam;
    public GameObject BrendaCam;
    public GameObject KattyCam;
    public int currenctRunnerIndex = 0;
    public GameObject[] runnersz;
   

    // Start is called before the first frame update
    void Start()
    {
        currenctRunnerIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);
        foreach (GameObject runner in runnersz)
            runner.SetActive(false);

        runnersz[currenctRunnerIndex].SetActive(true);

        if (currenctRunnerIndex == 0)
        {
            BettyDistance.SetActive(true);
            BettyCam.SetActive(true);
        }
        if (currenctRunnerIndex == 3)
        {
            nannyDistance.SetActive(true);
            nannyCam.SetActive(true);
        }
        if (currenctRunnerIndex == 1)
        {
            BrendaDistance.SetActive(true);
            BrendaCam.SetActive(true);
        }
        if (currenctRunnerIndex == 2)
        {
            KattyDistance.SetActive(true);
            KattyCam.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
