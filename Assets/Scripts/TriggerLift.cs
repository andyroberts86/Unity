using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLift : MonoBehaviour
{
    private GameObject obj;

    // Use this for initialization
    void Start()
        {
        obj = GetComponent<GameObject>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
