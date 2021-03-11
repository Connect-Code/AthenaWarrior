using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource deny_sfx, btn_click;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayClickBtn()
    {
        btn_click.Play();
    }

    public void PlayDenyBtn()
    {
        deny_sfx.Play();
    }
}
