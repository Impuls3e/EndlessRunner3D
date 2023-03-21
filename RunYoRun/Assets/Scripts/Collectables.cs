using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectables : MonoBehaviour

   
{
 

    public int rotateSpeed = 1;

     void Start()
    {
       
        
    }


    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);

       

    }
}
