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
            Instantiate(prefab, new Vector3(Random.Range(-5.0f, 5.0f), 0, 8 + 10*i ), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
