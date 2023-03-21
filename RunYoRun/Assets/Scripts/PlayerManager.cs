using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
 
    public GameObject player1;
    public GameObject charModel1;
    public AudioSource crushSFX1;
    public GameObject mainCamera1;
    public Animator animator1;
    private bool isHitting1 = false;

    public GameObject levelController;


    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        player1.GetComponent<Control22>().enabled = false;
        isHitting1 = true;
        animator1.SetBool("isHitting", true);

        crushSFX1.Play();
        levelController.GetComponent<LevelDistance>().enabled = false;
        mainCamera1.GetComponent<Animator>().enabled = true;
        
    }

}


