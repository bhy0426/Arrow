using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f; // 이동속도

    private float rotationY;

    void Update()
    {
        Move(); // WASD 이동
        //MouseRotate(); // 마우스 회전에 따른 플레이어 회전
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(0, 0, horizontal);
        transform.Translate(move.normalized * Time.deltaTime * speed);
    }

    //private void MouseRotate()
    //{
    //    rotationY += Input.GetAxisRaw("Mouse X") * GameManager.Instance.mouseSensitivity * Time.deltaTime; // 마우스X축 방향 값을 플레이어 회전 Y축(좌우) 값으로 설정
    //    transform.localRotation = Quaternion.Euler(0f, rotationY, 0f); 
    //}
}
