using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour
{
    public Rigidbody rb;
    public Transform cam;
    public bool grounded = true;


    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if(grounded == true)
            {
             rb.drag = 0;
             grounded = false;
             rb.AddRelativeForce (0, 850, 0);
        }   }
        rb = GetComponent<Rigidbody>();
    }

    // Update is caled once per frame
    void FixedUpdate()
    {

        
        if (Input.GetKey("w"))
        {
            if(grounded == true)
            {
              transform.LookAt(new Vector3 (cam.position.x, transform.position.y, cam.position.z));
              transform.Rotate(0, 180, 0);

             rb.AddRelativeForce (0, 0, 4000 * Time.deltaTime);
             rb.drag = 5;
            } 
        }

        if(Input.GetKeyUp("w") && grounded == true)
        {
           rb.drag = 10;
        }
    }
    void OnCollisionEnter ()
    {
        rb.drag = 5;
        grounded = true;
    }
    void OnCollisionExit ()
    {
        rb.drag = 0;
        grounded = false;
    }
    void OnCollisionEnter (Collision col)
    {
        Debug.Log(col.collider.name);

    }

}   
    