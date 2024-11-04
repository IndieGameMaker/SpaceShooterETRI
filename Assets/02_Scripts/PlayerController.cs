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

        // transform.position += new Vector3(0, 0, 0.1f);
        transform.position += Vector3.forward * 0.1f;

        // Debug.Log($"h={h} / v={v}");
    }
}
