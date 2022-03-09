using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPlane : MonoBehaviour
{
    public Rigidbody rb;

    private bool aKey = false;
    private bool dKey = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        aKey = Input.GetKeyDown("a");
        dKey = Input.GetKeyDown("d");
    }

    void FixedUpdate() {
        if (aKey) {
            rb.velocity = new Vector3(-10, 0, 0);
        }
        if (dKey) {
            rb.velocity = new Vector3(10,0,0);
        }
        // else {
        //     rb.velocity = new Vector3(0, 0, 0);
        // }
    }
}
