using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossZoneTle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider collision) // 当たり判定を察知
    {

        if (collision.gameObject.tag == "Player")
        {

            SceneManager.LoadScene("Boss1");
        }
    }
}
