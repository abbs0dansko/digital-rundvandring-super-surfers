using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 using UnityEngine;
 using UnityEngine.UI;
 using TMPro;
 using System.Collections;

public class GetPlaneInformation : MonoBehaviour
{

    public Button yourButton;
    public GameObject panelOb;
    Image panel;
    public Animation anim;
    //public GameObject outlineOBj;
    string planeName;
    bool panelOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        panel = panelOb.GetComponent<Image>();
        yourButton.onClick.AddListener(closePanel);

    }

    void closePanel(){
        Color c = panel.color;
        c.a = 0;
        panel.color = c;
        for(int i = 0; i < panelOb.transform.childCount; i++) {
            panelOb.transform.GetChild(i).gameObject.SetActive(false);
        }
        panelOpen = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray temp_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(temp_ray, out hit) && panelOpen == false) {
                for(int i = 0; i < panelOb.transform.childCount; i++) {
                    panelOb.transform.GetChild(i).gameObject.SetActive(true);
                }
                panelOpen = true;
                // panelOb.transform.GetChild(0).gameObject.SetActive(true);
                // panelOb.transform.GetChild(1).gameObject.SetActive(true);
                // panelOb.transform.GetChild(2).gameObject.SetActive(true);
                Transform objectHit = hit.transform;
                Debug.Log("object hit");
                anim.Play();
                Color c = panel.color;
                c.a = 100;
                //outlineOBj.GetComponent<Outline>().enabled = true;
                panel.color = c;
                // Do something with the object that was hit by the raycast.
            }
        }

        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit) && panelOpen == false)
            {
                panelOpen = true;
                Transform objectHit = Hit.transform;
                Debug.Log("object hit");
                anim.Play();
                Color c = panel.color;
                c.a = 100;
                panel.color = c;
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
