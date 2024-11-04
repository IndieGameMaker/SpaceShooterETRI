using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float h;
    private float v;
    private float r;

    public float moveSpeed = 8.0f;
    public float turnSpeed = 500.0f;

    void Start()
    {

    }

    void Update()
    {
        v = Input.GetAxis("Vertical"); // Up/Down, W/S -1.0f ~ 0.0f ~ +1.0f
        h = Input.GetAxis("Horizontal"); // -1.0f ~ 0.0f ~ +1.0f
        r = Input.GetAxis("Mouse X");

        // 이동처리 로직
        // 벡터의 덧셈
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
        transform.Translate(moveDir.normalized * Time.deltaTime * 8.0f);

        // 회전 처리로직
        transform.Rotate(Vector3.up * Time.deltaTime * r * 500.0f);
    }
}

/*
    Vector3.forward = Vector3(0, 0, 1)
    Vector3.up      = Vector3(0, 1, 0)
    Vector3.right   = Vector3(1, 0, 0)

    Vector3.one  = Vector3(1, 1, 1)
    Vector3.zero = Vector3(0, 0, 0)
*/








