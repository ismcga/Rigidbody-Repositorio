using UnityEngine;

public class MovimientoWASD : MonoBehaviour
{
    public float fuerza = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 direccion = new Vector3(h, 0, v);
        rb.AddForce(direccion * fuerza, ForceMode.Force);
    }
}