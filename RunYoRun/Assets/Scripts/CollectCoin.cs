using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;
 

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")

        {
            PlayerManager1.NumberOfCoins += 10;
            Debug.Log("Coins:" +PlayerManager1.NumberOfCoins);
            Destroy(gameObject);
            coinFX.Play();
             

        }
      
        
     
    }


}
