using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLift : MonoBehaviour
{
    private GameObject obj;
    public GameObject lift;
    private Animator anim;

    // Use this for initialization
    void Start()
        {
        obj = GetComponent<GameObject>();
        anim = lift.GetComponent<Animator>();
        anim.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            anim.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
