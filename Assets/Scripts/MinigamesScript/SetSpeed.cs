using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpeed : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(0, 0, -5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
