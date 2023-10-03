using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EneRes : MonoBehaviour
{
    GameObject enemy;
    public GameObject EnemyPre;
    private float interval;
    private float reS = 1000f;



    float RandX = 0;
    float RandY = 0;
    float timeGrow = 1.01f;
    // Start is called before the first frame update
    void Start()
    {
        interval = 1000f;
    }



    // Update is called once per frame
    void Update()
    {
        reS *= timeGrow;



        if (reS >= interval)
        {
            reS = 1;
            enemy = Instantiate(EnemyPre);
            enemy.transform.position = new Vector3(RandX, 10, RandY);
            
        }


        RandX = Random.Range(-30, 30);
        RandY = Random.Range(-30, 30);
    }
}