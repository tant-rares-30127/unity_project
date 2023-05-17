using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRoling : MonoBehaviour
{
    public Rigidbody rb;
    public float torqueMultiplier = 2f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotationDirection = Vector3.Cross(rb.velocity, transform.up);

        float rotationAmount = rb.velocity.magnitude * Time.fixedDeltaTime * torqueMultiplier;

        transform.Rotate(rotationDirection, rotationAmount * Mathf.Rad2Deg);

        rb.AddTorque(rotationDirection * rotationAmount, ForceMode.Impulse);
    }
}
