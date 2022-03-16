using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;




public class ButtonAction : MonoBehaviour

{  

    public Animator anim;

    bool animBool = true;

    public GameObject planePrefab;

    bool spawned = false;
    public GameObject panelOb;


    bool AnimatorIsPlaying()

    {

     return anim.GetCurrentAnimatorStateInfo(0).length >

            anim.GetCurrentAnimatorStateInfo(0).normalizedTime;

    }



    public void planeFly()

    {



        if(animBool == true)

        {
            // panelOb.gameObject.enabled = false;
            
            // anim.SetBool("flyAway", true);

            animBool = false;
            panelOb.gameObject.SetActive(false);
            
            StartCoroutine(CoolDownRoutine());
            SceneManager.LoadScene(1);
        }


    }



    IEnumerator CoolDownRoutine()

    {
        
        WaitForSeconds waitForSeconds = new WaitForSeconds(6f);

        yield return waitForSeconds;
    }



}