using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerRb : MonoBehaviour
{
    public GameObject camera;

    Rigidbody myRb;

    Rigidbody cameraRb;

    Vector2 moveInfo;

    // Start is called before the first frame update
    void Start()
    {


        myRb = this.GetComponent<Rigidbody>();
        cameraRb =camera.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
           
        }
        if (moveInfo != Vector2.zero)
        {
            myRb.position += cameraRb.transform.forward * 0.02f;
        }

        
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        // スティックの入力を受け取る
        moveInfo = context.ReadValue<Vector2>();
    }

}
