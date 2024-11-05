using System;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    [SerializeField] private GameObject sparkEffect;

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("BULLET"))
        {
            // ContactPoint
            ContactPoint cp = other.GetContact(0);

            // 접점
            Vector3 pos = cp.point;
            // 법선벡터
            Vector3 _normal = -cp.normal;
            // 벡터를 쿼터니언 타입으로 변환
            Quaternion rot = Quaternion.LookRotation(_normal);

            // 쿼터니언(Quaternion : 사원수 x, y, z, w)

            // 스파크 생성
            var obj = Instantiate(sparkEffect, pos, rot);
            Destroy(obj, 0.5f);

            Destroy(other.gameObject);
        }
    }

}
