﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class CameraFocus : NetworkBehaviour
{
    public GameObject target;
    //ThirdPersonCamera thirdPersonCamera;


    void Start()
    {
        if (isLocalPlayer)
        {
            Debug.Log("Setting up camera...");
            
            thirdPersonCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<ThirdPersonCamera>();
            thirdPersonCamera.target = target;
            mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

            mainCamera.transform.position = target.transform.position;
            //thirdPersonCamera.offset = target.transform.position - mainCamera.transform.position;



        }
    }

    Camera mainCamera;
    ThirdPersonCamera thirdPersonCamera;
}
