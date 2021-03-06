﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamControl : MonoBehaviour {

    public Transform currentMount;
    public float speedFactor = 0.1f;

	//Use this for initialization
	void Start () {
		
	}
	
	//Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position, currentMount.position, speedFactor);
        transform.rotation = Quaternion.Slerp(transform.rotation, currentMount.rotation, speedFactor);

	}

    public void SetMount(Transform newMount)
    {
        currentMount = newMount;
    }
}
