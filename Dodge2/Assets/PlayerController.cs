using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //이동에 사용할 리지드바디 컴포넌트
    public Rigidbody playerRigidbody;
    //이동 속력
    public float speed = 8f; //아무리 default로 지정해도 inspector값이 우선순위가 있다

    //내 자신을 담을 변수
    public GameObject my;


    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }
    

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        //키보드: 'A',<-음의 방향 :-1.0f
        //키보드:'d',->:양의 방향 : +1.0f
        float zInput = Input.GetAxis("Vertical");
        //키보드 : 'W',^:양의 방향 :+1.0f
        //키보드:'s',아래방향:음의방향:-1.0f}


    void DirectInput()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //위쪽 방향키 감지된 경우
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
