using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject pauseIma;

    bool pause=false;
    // Start is called before the first frame update
    void Start()
    {
        pauseIma.SetActive(pause);
    }

    // Update is called once per frame
    void Update()
    {
        //ê‡ñæÇÕïsóvÉiÉä
        if(Input.GetKeyDown(KeyCode.P))
        {
            pause = true;

            pauseIma.SetActive(pause);
            Time.timeScale = 0;
        }
        
    }
}
