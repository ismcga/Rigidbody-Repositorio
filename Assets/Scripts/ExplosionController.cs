using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    public float fuerza = 500f;
    public float radio = 5f;
    public float elevacion = 2f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Explode();
        }
    }

    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radio);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(fuerza, transform.position, radio, elevacion);
            }
        }
    }
}