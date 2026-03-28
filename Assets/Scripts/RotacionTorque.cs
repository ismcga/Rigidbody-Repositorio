using UnityEngine;

public class RotacionTorque : MonoBehaviour
{
    public float torque = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(Vector3.up * -torque);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(Vector3.up * torque);
        }
    }
}