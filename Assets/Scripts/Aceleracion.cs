using UnityEngine;

public class Aceleracion : MonoBehaviour
{
    public float fuerza = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);

        rb.AddForce(dir * fuerza, ForceMode.Acceleration);
    }
}