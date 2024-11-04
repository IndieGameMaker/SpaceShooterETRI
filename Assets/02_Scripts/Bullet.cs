using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward * 1200.0f);
    }
}
