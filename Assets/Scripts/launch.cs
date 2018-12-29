using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launch : MonoBehaviour {
    public GameObject startCamera;

	// Use this for initialization
	void Start () {
        Camera mainCam = Camera.main;
        mainCam.gameObject.SetActive(false);

        startCamera.SetActive(true);

        Physics.gravity = new Vector3(0f, -9.81f, 0f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
