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
