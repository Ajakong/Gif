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
    float RandZ = 0;
    float timeGrow = 1.05f;
    // Start is called before the first frame update
    void Start()
    {
        interval = 1000f;
    }



    // Update is called once per frame
    void Update()
    {
        



        if (reS >= interval)
        {
            reS = 1;
            enemy = Instantiate(EnemyPre);
            enemy.transform.position = new Vector3(transform.position.x+RandX, 10, transform.position.z+RandZ);
            
        }


        RandX = Random.Range(-30, 30);
        RandZ = Random.Range(-30, 30);
    }

    private void FixedUpdate()
    {
        reS *= timeGrow;
    }
}