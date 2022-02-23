using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlaneInformation : MonoBehaviour
{
    //public GameObject plane;
    string planeName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                planeName = Hit.transform.name;
                switch (planeName)
                {
                    case "Rafale":
                        Debug.Log("Rafale is a plane");
                        break;
                }
            }
        }
    }
}
