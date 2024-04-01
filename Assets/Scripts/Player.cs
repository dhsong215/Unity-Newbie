using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // SerializedField -> 이걸로 유니티에서 아래 선언한 moveSpeed에 접근해서 편집 가능. 실시간으로 값을 수정하며 적정 스피드를 찾기 수월하다.
    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private GameObject weapon; // Prefab 쓰기 위해 GameObj 객체 선언, 여기에 Weapon Prefab 넣는다.

    [SerializeField]
    private Transform shootTransform; // Player 하위 ShootTransform Obj(총알이 나가는 오브젝트) 넣는다. 위치값만 필요해서 Transform으로 선언.

    [SerializeField]
    private float shootInterval;
    private float lastShotTime = 0f;

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float toX = Mathf.Clamp(mousePos.x, -2.35f, 2.35f); // 마우스 포지션의 위치인데 절댓값 2.35를 넘지 않는 변수를 할당하고 이걸 넣어줄거임
        transform.position = new Vector3(toX, transform.position.y, transform.position.z);

        Shoot();

    }

    void Shoot() {
        // Time.time 은 게임이 시작되고 현재까지 흐른 시간
        if (Time.time - lastShotTime > shootInterval) {
            Instantiate(weapon, shootTransform.position, Quaternion.identity);
            lastShotTime = Time.time;
        }
    }
    
}
