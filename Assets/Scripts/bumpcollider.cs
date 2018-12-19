using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumpcollider : MonoBehaviour {
    public GameObject newCamera;

	// Use this for initialization
	void Start () {
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Camera mainCam = Camera.main;
            mainCam.gameObject.SetActive(false);
            
            newCamera.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
