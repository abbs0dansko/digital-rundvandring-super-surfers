using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpeed : MonoBehaviour
{
    public Rigidbody rb;
    // public GameObject ring;
    public GameObject prefab;
    private bool hit = false;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(0, 0, -5);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.z < -10) {
            if (hit == false) {
                Debug.Log("Du förlorade");
            }
            Instantiate(prefab, new Vector3(Random.Range(-4.0f, 4.0f), 0, 88 ), Quaternion.identity);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        hit = true;
    }
}
