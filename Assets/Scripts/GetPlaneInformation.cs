using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 using UnityEngine;
 using UnityEngine.UI;
 using System.Collections;

public class GetPlaneInformation : MonoBehaviour
{
    public Image panel;
    public Animation anim;
    string planeName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray temp_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(temp_ray, out hit)) {
                Transform objectHit = hit.transform;
                Debug.Log("object hit");
                anim.Play();
                Color c = panel.color;
                c.a = 100;
                panel.color = c;
                // Do something with the object that was hit by the raycast.
                SceneManager.LoadScene(1);
            }
        }

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
                        Debug.Log("You clicked on rafale");
                        break;
                }
                SceneManager.LoadScene(1);
            }
        }
    }
}
