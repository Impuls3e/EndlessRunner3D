using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")

        {
            CoinCounters2.CoinsCount += 10;

           
           
           


        }



    }
}
