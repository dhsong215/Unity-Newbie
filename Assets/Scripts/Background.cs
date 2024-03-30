using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    //private 는 다른 함수나 클래스에서 접근 불가
    //f를 붙이면 실수 의미
    private float moveSpeed = 3f;

    // Update is called once per frame
    void Update()
    {
        //Vector3는 유니티 자체 제공
        //Time.deltaTime을 곱하는 이유는 서로 다른 프레임이 나와도 시간이 지남에 따라 일정하게 움직이게 하기 위해
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        if (transform.position.y < -10) {
            transform.position += new Vector3(0, 20f, 0);
        }
    }
}
