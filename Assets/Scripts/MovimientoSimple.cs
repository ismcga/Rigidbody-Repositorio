using UnityEngine;

public class MovimientoSimple : MonoBehaviour
{
    public float fuerza = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * fuerza, ForceMode.Force);
        }
    }
}