using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateRing : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i < 10; i++) {
            
            GameObject test = Instantiate(prefab, new Vector3(Random.Range(-4.0f, 4.0f), -1, 20 + 10*i ), Quaternion.identity);
            test.transform.parent = gameObject.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
