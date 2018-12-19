using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour {
    public Camera newCamera;
    public Camera[] allCameras;

    // Use this for initialization
    void Start()
    {
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            for(int i = 0; i< allCameras.Length; i++)
            {
                allCameras[i].enabled = false;
            }
            newCamera.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}