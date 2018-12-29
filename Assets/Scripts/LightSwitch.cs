using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public List<Light> endLights;
    public GameObject blocker;
    private Animator anim;
    public AudioSource aSrc;
    public AudioClip aClip;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
        blocker.GetComponent<Animator>().enabled = false;
        foreach (Light l in endLights)
        {
            l.enabled = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            aSrc.PlayOneShot(aClip);
            anim.enabled = true;
            blocker.GetComponent<Animator>().enabled = true;
            foreach (Light l in endLights)
            {
                l.enabled = true;
            }
        }
    }
}
