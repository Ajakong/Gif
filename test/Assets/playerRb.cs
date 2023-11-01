using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class playerRb : MonoBehaviour
{
    public GameObject camera;

    Rigidbody myRb;

    Rigidbody cameraRb;

    //cameraRotate cameForWard;

    Vector2 moveInfo;

    Vector3 forWard;

    Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        //cameForWard = camera.GetComponent<cameraRotate>();

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
            Debug.Log(moveInfo);
            myRb.position += cameraRb.transform.forward * 0.08f;
            rotation.y=moveInfo.x;
            transform.rotation = rotation;
        }
        if (Mathf.Abs(moveInfo.x) > 0.001f)
        {
            // 回転軸はワールド座標のY軸
            this.transform.RotateAround(this.transform.position, Vector3.up, moveInfo.x * 5f);
        }
        
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        // スティックの入力を受け取る
        moveInfo = context.ReadValue<Vector2>();
    }

}
