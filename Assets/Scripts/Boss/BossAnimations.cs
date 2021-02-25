using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAnimations : MonoBehaviour
{
    [SerializeField] private Animator charAnimator;

    public void Idle()
    {
        Debug.Log("IDLE ANIMATION");
        charAnimator.SetBool("Idle", true);
        charAnimator.SetBool("Hurt", false);
    }

    public void Hurt()
    {
        Debug.Log("HURT ANIMATION");
        charAnimator.SetBool("Idle", false);
        charAnimator.SetBool("Hurt", true);
    }
}
