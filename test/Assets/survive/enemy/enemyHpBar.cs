using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHpBar : MonoBehaviour
{
    GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = camera.transform.rotation;
    }
}
