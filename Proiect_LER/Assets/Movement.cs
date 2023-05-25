using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float jumpForce = 70.0f;
    public bool isWall = true;
    public float forceStrenghts = 0.03f;
    //public Vector3 Vec;

    private Rigidbody rb;
   // public float jumpHeight = 7f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.R))
        {
            rb.transform.position = (new Vector3(-1.9f, 8.0f, -0.3f));
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(new Vector3(-3.5f, 0f, 0f) * Time.deltaTime, Space.World);

            if (isWall == true) rb.AddForce(-Vector3.right * forceStrenghts);
        }
         if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(new Vector3(3.5f, 0f, 0f) * Time.deltaTime, Space.World);
            if (isWall == true) rb.AddForce(Vector3.right * forceStrenghts);
        }
         if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(new Vector3(0f, 0f, 3.5f) * Time.deltaTime, Space.World);
            if (isWall == true) rb.AddForce(Vector3.forward * forceStrenghts);

        }
         if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(new Vector3(0f, 0f, -3.5f) * Time.deltaTime, Space.World);
            if (isWall == true) rb.AddForce(-Vector3.forward * forceStrenghts);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isWall)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isWall= false;
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Wall"))
        {
            isWall = true;
        }

        if (collision.gameObject.CompareTag("Floor"))
        {
            rb.transform.position = (new Vector3(-1.9f, 8.0f, -0.3f));
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
    


}
