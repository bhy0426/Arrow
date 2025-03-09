using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public Transform targetTransform; // 플레이어
    private float distanceY = 0.5f; // 플레이어 머리 상대 좌표

    private float rotationX;
    private float rotationY;

    void Update()
    {
        Cursor.visible = false; // 마우스 커서 비활성화 
        Cursor.lockState = CursorLockMode.Locked; // 마우스 커서 고정

        InitPosition(); // 플레이어 머리에 카메라 고정
        MouseRotate(); // 마우스 회전에 따른 카메라 회전
    }

    private void InitPosition()
    {
        transform.position = new Vector3(targetTransform.position.x, targetTransform.position.y + distanceY, targetTransform.position.z);
    }

    private void MouseRotate()
    {
        rotationX -= Input.GetAxisRaw("Mouse Y") * GameManager.Instance.mouseSensitivity * Time.deltaTime; // 좌우
        rotationY += Input.GetAxisRaw("Mouse X") * GameManager.Instance.mouseSensitivity * Time.deltaTime; // 상하

        rotationX = Mathf.Clamp(rotationX, -45f, 90f); // 

        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0f);
    }
}
