using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapone : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        // Prefab 오브젝트 무한 생성 방지
        Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * moveSpeed * Time.deltaTime;
    }
}
