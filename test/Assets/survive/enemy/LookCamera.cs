using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookCamera : MonoBehaviour
{
    GameObject enemy;
    Vector3 enemyPos;

    GameObject camera;
    Vector3 cameraPos;
    Quaternion cameraRot;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("enemy");

        camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        enemyPos = enemy.transform.position;
        //enemyPos.y += 20;
        transform.position = enemyPos;

        cameraPos = camera.transform.position;
        cameraRot = Quaternion.LookRotation(cameraPos);

        this.transform.rotation = cameraRot;
    }
}
