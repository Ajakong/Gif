using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cameraRb : MonoBehaviour
{
    //�J�����̐e�I�u�W�F�N�g
    GameObject cameraMoveBase;
    //�J�����̐e�I�u�W�F�N�g��transform
    Transform cameraMoveBaseTra;

    Rigidbody cameraRB;
    //�X�e�B�b�N�̓��͏��(�J����)
    Vector2 cameraInfo;

    //�J�����̉�]���x
    float rotateSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        

        cameraMoveBaseTra = cameraMoveBase.transform;

        cameraRB = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraInfo != Vector2.zero)
        {
            var mov = new Vector3(cameraInfo.x * rotateSpeed * Time.deltaTime, 0, cameraInfo.y * rotateSpeed * Time.deltaTime);

            // X�����Ɉ��ʈړ����Ă���Ή���]
            if (Mathf.Abs(cameraInfo.x) > 0.001f)
            {
                // ��]���̓��[���h���W��Y��
                this.transform.RotateAround(this.transform.position, Vector3.up, cameraInfo.x * 5f);
            }
            // Y�����Ɉ��ʈړ����Ă���Ώc��]
            //if (Mathf.Abs(cameraInfo.y) > 0.001f)
            //{
            //    // ��]���̓J�������g��X��
            //    cameraMoveBase.transform.RotateAround(cameraMoveBase.transform.position, -Vector3.right, cameraInfo.y * 1f);
            //}



            // �ړ�������
            cameraMoveBaseTra.localEulerAngles = cameraMoveBaseTra.localEulerAngles + mov;
        }

    }

    public void OnCameraMove(InputAction.CallbackContext context)
    {
        //Debug.Log("cameraMove");
        // �X�e�B�b�N�̓��͂��󂯎��
        cameraInfo = context.ReadValue<Vector2>();

        //// �ړ��ʂ��v�Z
        //var mov = new Vector3(cameraInfo.x * speed * Time.deltaTime, 0, cameraInfo.y * speed * Time.deltaTime);


        //if (context.phase == InputActionPhase.Waiting)
        //{
        //    return;
        //}
        //if (context.phase == InputActionPhase.Started)
        //{
        //    return;
        //}

        //if (context.phase == InputActionPhase.Performed)
        //{
        //    // X�����Ɉ��ʈړ����Ă���Ή���]
        //    if (Mathf.Abs(cameraInfo.x) > 0.001f)
        //    {
        //        // ��]���̓��[���h���W��Y��
        //        cameraMoveBase.transform.RotateAround(cameraMoveBase.transform.position, Vector3.up, cameraInfo.x * 5f);
        //    }
        //    // Y�����Ɉ��ʈړ����Ă���Ή���]
        //    if (Mathf.Abs(cameraInfo.y) > 0.001f)
        //    {
        //        // ��]���̓��[���h���W��Y��
        //        cameraMoveBase.transform.RotateAround(cameraMoveBase.transform.position, -Vector3.right, cameraInfo.y * 1f);
        //        return;
        //    }
        //}
        //if (context.phase == InputActionPhase.Canceled)
        //{
        //    return;
        //}

        //// �ړ�������
        ////cameraMoveBaseTra.localEulerAngles = cameraMoveBaseTra.localEulerAngles + mov;
        //cameraMoveBaseTra.localEulerAngles += mov;
    }

}