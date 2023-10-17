using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UniState : MonoBehaviour
{
    int HealNum=3;

    int UniHp=100;
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

        if(Input.GetKeyUp(KeyCode.H))
        {
            if(HealNum>=1)
            {
                if (UniHp < 100)
                {
                    UniHp += 60;
                    HealNum--;
                }
                else
                {
                    Debug.Log("HPがマンタンDEATH！");
                }

            }
        }
    }

    public int UniHpMove
    {
        get { return UniHp; }
        set { UniHp = value; }
    }
}
