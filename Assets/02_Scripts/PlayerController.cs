using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float h;
    private float v;

    void Start()
    {

    }

    void Update()
    {
        v = Input.GetAxis("Vertical"); // Up/Down, W/S -1.0f ~ 0.0f ~ +1.0f
        h = Input.GetAxis("Horizontal"); // -1.0f ~ 0.0f ~ +1.0f

        // 벡터의 덧셈
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
        transform.Translate(moveDir * Time.deltaTime * 8.0f);
    }
}

/*
    Vector3.forward = Vector3(0, 0, 1)
    Vector3.up      = Vector3(0, 1, 0)
    Vector3.right   = Vector3(1, 0, 0)

    Vector3.one  = Vector3(1, 1, 1)
    Vector3.zero = Vector3(0, 0, 0)
*/








