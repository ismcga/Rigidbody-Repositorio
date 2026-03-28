using UnityEngine;

public class CocheController : MonoBehaviour
{
    public float fuerzaAceleracion = 1000f;
    public float fuerzaFrenado = 500f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * fuerzaAceleracion);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * fuerzaFrenado);
        }
    }
}