using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "BULLET")
        {
            Destroy(other.gameObject);
        }
    }
}
