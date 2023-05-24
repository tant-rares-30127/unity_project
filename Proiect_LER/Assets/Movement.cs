using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float jumpForce = 70.0f;
    public bool isWall = true;
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
            rb.transform.position = (new Vector3(-0.29f, 6.0f, -0.04f));
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(new Vector3(-5f, 0f, 0f) * Time.deltaTime, Space.World);
        }
         if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(new Vector3(5f, 0f, 0f) * Time.deltaTime, Space.World);
        }
         if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(new Vector3(0f, 0f, 5f) * Time.deltaTime, Space.World);
        }
         if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(new Vector3(0f, 0f, -5f) * Time.deltaTime, Space.World);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isWall)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isWall= false;
        }

        

        /*      
              transform.Translate(Vector3.right * Time.deltaTime * speed * Input.GetAxis("Horizontal"));
              transform.Translate(Vector3.up * Time.deltaTime * speed * Input.GetAxis("Jump"));
              transform.Translate(Vector3.forward * Time.deltaTime * speed * Input.GetAxis("Vertical"));*/

        /*Vec = transform.localPosition;
        Vec.y += Input.GetAxis("Jump") * Time.deltaTime * 20;
        Vec.z -= Input.GetAxis("Horizontal") * Time.deltaTime * 20;
        Vec.x += Input.GetAxis("Vertical") * Time.deltaTime * 20;
        transform.localPosition = Vec;*/
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Wall"))
        {
            isWall = true;
        }
    }
    


}
