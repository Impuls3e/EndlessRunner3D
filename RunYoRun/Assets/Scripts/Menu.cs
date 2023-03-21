using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject idleAnim;
    // Start is called before the first frame update
    void Start()
    {
        idleAnim.GetComponent<Animator>().Play("Orc Idle");
    }

  
}
