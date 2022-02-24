using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�̵��� ����� ������ٵ� ������Ʈ
    public Rigidbody playerRigidbody;
    //�̵� �ӷ�
    public float speed = 8f; //�ƹ��� default�� �����ص� inspector���� �켱������ �ִ�

    //�� �ڽ��� ���� ����
    public GameObject my;


    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }
    

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        //Ű����: 'A',<-���� ���� :-1.0f
        //Ű����:'d',->:���� ���� : +1.0f
        float zInput = Input.GetAxis("Vertical");
        //Ű���� : 'W',^:���� ���� :+1.0f
        //Ű����:'s',�Ʒ�����:���ǹ���:-1.0f}


    void DirectInput()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //���� ����Ű ������ ���
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
    }

    void Die()
    {
        my.SetActive(false);
        
    }


}

    
}
