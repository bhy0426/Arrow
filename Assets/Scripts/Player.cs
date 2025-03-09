using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f; // �̵��ӵ�

    private float rotationY;

    void Update()
    {
        Move(); // WASD �̵�
        //MouseRotate(); // ���콺 ȸ���� ���� �÷��̾� ȸ��
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
    //    rotationY += Input.GetAxisRaw("Mouse X") * GameManager.Instance.mouseSensitivity * Time.deltaTime; // ���콺X�� ���� ���� �÷��̾� ȸ�� Y��(�¿�) ������ ����
    //    transform.localRotation = Quaternion.Euler(0f, rotationY, 0f); 
    //}
}
