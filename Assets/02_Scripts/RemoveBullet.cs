using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        //if (other.gameObject.tag == "BULLET")
        if (other.collider.CompareTag("BULLET"))
        {
            Destroy(other.gameObject);
        }
    }
}
