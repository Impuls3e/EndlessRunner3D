using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelDistance : MonoBehaviour
{
    public GameObject distDisplay;

    public int distRun;
    public bool addingDist = false;
    public float disDelay = 0.35f;

    // Update is called once per frame
    void Update()
    {
        if (addingDist == false)
        {
            addingDist = true;
            StartCoroutine(AddingDist());
        }
    }

    IEnumerator AddingDist()
    {

        distRun += 1;
        distDisplay.GetComponent<Text>().text = "" + distRun;
        yield return new WaitForSeconds(disDelay);
        addingDist = false;

    }
}
