using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAction : MonoBehaviour
{  
    public Animator anim;
    bool animBool = true;
    public GameObject planePrefab;

    bool AnimatorIsPlaying()
    {
     return anim.GetCurrentAnimatorStateInfo(0).length >
            anim.GetCurrentAnimatorStateInfo(0).normalizedTime;
    }

    public void planeFly()
    {
        if(animBool == true)
        {
            anim.SetBool("flyAway", true);
            animBool = false;
            StartCoroutine(CoolDownRoutine());
        }
    }

    IEnumerator CoolDownRoutine()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(3.0f);

        yield return waitForSeconds;
        Destroy(planePrefab);
    }

}
