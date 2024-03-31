using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // SerializedField -> 이걸로 유니티에서 아래 선언한 moveSpeed에 접근해서 편집 가능. 실시간으로 값을 수정하며 적정 스피드를 찾기 수월하다.
    [SerializeField]
    private float moveSpeed;

    void Update()
    {
        // 아래의 코드는 마우스가 아닌 키보드로 캐릭터를 조종할때 예시입니다.
        // collider 컴포넌트를 캐릭터에 추가해 줘야 하며 화면 밖에 collider wall 컴포넌트를 추가해서 캐릭터가 화면 밖을 벗어나지 않도록 해줘야 합니다.
        // float horizontalInpout = Input.GetAxisRaw("Horizontal");
        // float verticalInput = Input.GetAxisRaw("Vertical");
        // Vector3 moveTo = new Vector3(horizontalInpout, 0f, 0f);
        // transform.position += moveTo * moveSpeed * Time.deltaTime;

        // Vector3 moveTo = new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
        // if (Input.GetKey(KeyCode.LeftArrow)) {
        //     transform.position -= moveTo;
        // } else if (Input.GetKey(KeyCode.RightArrow)) {
        //     transform.position += moveTo;
        // }

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float toX = Mathf.Clamp(mousePos.x, -2.35f, 2.35f); // 마우스 포지션의 위치인데 절댓값 2.35를 넘지 않는 변수를 할당하고 이걸 넣어줄거임
        transform.position = new Vector3(toX, transform.position.y, transform.position.z);
    }
}
