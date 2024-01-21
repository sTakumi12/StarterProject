using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class howtoplay : MonoBehaviour
{
 
    private GameObject howToPlay;

    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("Repeat", 0, 2);
    }

    // Update is called once per frame

    void Repeat()
    {
     
        Time.timeScale = 1;
    }
}            