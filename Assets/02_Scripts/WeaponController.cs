using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePos;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Bullet 생성
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }
    }
}

/*
    Collision Callback

    ## 충돌 조건
    1. 양쪽 다 Collider 컴포넌트 존재
    2. 이동하는 객체에는 Rigidbody


    ## Is Trigger 언체크

    OnCollisionEnter   1
    OnCollisionStay    n
    OnCollisionExit    1


    ## Is Trigger 체크

    OnTriggerEnter      1
    OnTriggerStay       n
    OnTriggerExit       1



*/