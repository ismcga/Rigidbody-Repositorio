using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;

    int mode = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha1)) mode = 1;
        if (Input.GetKeyDown(KeyCode.Alpha2)) mode = 2;
        if (Input.GetKeyDown(KeyCode.Alpha3)) mode = 3;
        if (Input.GetKeyDown(KeyCode.Alpha4)) mode = 4;
        if (Input.GetKeyDown(KeyCode.Alpha5)) mode = 5;
        if (Input.GetKeyDown(KeyCode.Alpha6)) mode = 6;
        if (Input.GetKeyDown(KeyCode.Alpha7)) mode = 7;
        if (Input.GetKeyDown(KeyCode.Alpha8)) Explode();

       
        if (mode == 5 && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);

        switch (mode)
        {
            case 1: 
                if (Input.GetKey(KeyCode.W))
                    rb.AddForce(Vector3.forward * 10f, ForceMode.Force);
                break;

            case 2: 
                rb.AddForce(dir * 10f, ForceMode.Force);
                break;

            case 3: 
                if (Input.GetKey(KeyCode.W))
                    rb.AddForce(transform.forward * 1000f, ForceMode.Force);

                if (Input.GetKey(KeyCode.S))
                    rb.AddForce(-transform.forward * 500f, ForceMode.Force);
                break;

            case 4: 
                rb.linearVelocity = dir.normalized * 5f;
                break;

            case 6: 
                rb.AddForce(dir * 5f, ForceMode.Acceleration);
                break;

            case 7: 
                if (Input.GetKey(KeyCode.LeftArrow))
                    rb.AddTorque(Vector3.up * -10f);

                if (Input.GetKey(KeyCode.RightArrow))
                    rb.AddTorque(Vector3.up * 10f);
                break;
        }
    }

    void Explode()
    {
        float force = 500f;
        float radius = 5f;
        float upwards = 2f;

        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider c in colliders)
        {
            Rigidbody rb = c.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius, upwards, ForceMode.Impulse);
            }
        }
    }
}