using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UniState : MonoBehaviour
{
    int UniHp=60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(UniHp<=0)
        {
            UniHp=0;
            //ですエフェクト
            SceneManager.LoadScene("GameOver");
        }
    }

    public int UniHpMove
    {
        get { return UniHp; }
        set { UniHp = value; }
    }
}
