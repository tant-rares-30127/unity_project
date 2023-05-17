using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        //offset = transform.position - sphere.transform.position; 
    }

    

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = sphere.transform.position + offset;
    }
}
