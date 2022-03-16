using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (gameObject.transform.position.z < -1) {
            if (hit == false) {
                Debug.Log("Du förlorade");
                SceneManager.LoadScene(0);
            }
            GameObject test = Instantiate(prefab, new Vector3(Random.Range(-4.0f, 4.0f), 0, 112 ), Quaternion.identity);
            test.transform.parent = GameObject.Find("AR Session Origin").transform;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        hit = true;
    }
}
