using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class unitychanMove : MonoBehaviour
{

    public Transform cameraPos;

    Rigidbody myRb;
    //移動速度
    float moveSpeed;

    //視点の移動速度

    //前に進んでいるか
    bool moveFrontFlag = false;
    //後ろに進んでいるかどうか
    bool moveBackFlag = false;
    //右
    bool moveRightFlag = false;
    //左
    bool moveLeftFlag = false;

    //カメラPos
    Vector3 CPos;
    Vector3 move1;
    Vector3 move2;

    Vector3 angle;

    Vector3 forceDirection;
    float forcePower;
    Vector3 force;
    bool jumpFlag = false;
    public bool flag = false;

    bool runFlag = false;

    GameObject sword;
    Transform swordTransform;

    public bool equipmentFlag = false;

    GameObject handObj;
    GameObject equipObj;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 0.15f;

        angle = new Vector3(0, 1.0f, 0);
        myRb = this.GetComponent<Rigidbody>();

        forceDirection = new Vector3(0f, 1.0f, 0f);
        forcePower = 6f;
        force = forcePower * forceDirection;

        sword = GameObject.Find("ObjSword");

        handObj = GameObject.Find("Character1_RightHandMiddle1");
        equipObj = GameObject.Find("J_Mune_root_00");

    }

    // Update is called once per frame
    void Update()
    {
        CPos = cameraPos.position;
        move1 = transform.forward * moveSpeed;
        move2 = transform.right * moveSpeed;

        // マウスの移動量を取得
        float mx = Input.GetAxis("Mouse X");

        // X方向に一定量移動していれば横回転
        if (Mathf.Abs(mx) > 0.00001f)
        {
            // 回転軸はワールド座標のY軸
            transform.RotateAround(myRb.transform.position, Vector3.up, mx * 1.5f);
        }


        if (Input.GetKey(KeyCode.W))
        {
            moveFrontFlag = true;
        }
        else
        {
            moveFrontFlag = false;
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveBackFlag = true;
        }
        else
        {
            moveBackFlag = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveRightFlag = true;
        }
        else
        {
            moveRightFlag = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveLeftFlag = true;
        }
        else
        {
            moveLeftFlag = false;
        }

        //マウスカーソルを消す
        if (Input.GetMouseButton(2))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        //ジャンプ
        if (Input.GetKey(KeyCode.Space) && !flag)
        {
            jumpFlag = true;

        }
        else
        {
            jumpFlag = false;
        }

        //走る
        if (Input.GetKey(KeyCode.LeftShift))
        {
            runFlag = true;
        }
        else
        {
            runFlag = false;
            moveSpeed = 0.15f;
        }

        //剣をしまう
        if (Input.GetKeyDown(KeyCode.Tab) && !equipmentFlag)
        {
            //equipmentFlag = true;
        }

    }

    void FixedUpdate()
    {
        if (moveFrontFlag)
        {
            myRb.position += move1;
        }

        if (moveBackFlag)
        {
            myRb.position -= move1;
        }

        if (moveRightFlag)
        {
            myRb.position += move2;
        }

        if (moveLeftFlag)
        {
            myRb.position -= move2;
        }

        if (jumpFlag)
        {
            flag = true;
            myRb.AddForce(force, ForceMode.Impulse);
            CPos.y -= 2;
            cameraPos.transform.position = CPos;
        }

        if (runFlag)
        {
            moveSpeed = 0.4f;
        }

        //しまう
        if (equipmentFlag)
        {
            sword.gameObject.transform.parent = equipObj.gameObject.transform;

        }

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ground")
        {
            flag = false;
        }
    }
}
