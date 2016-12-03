using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class CameraFocus : NetworkBehaviour
{
    public GameObject target;



    void Start()
    {
        if (isLocalPlayer)
        {
            Debug.Log("Setting up camera...");
            thirdPersonCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<ThirdPersonCamera>();
            thirdPersonCamera.target = target;
            mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

            thirdPersonCamera.offset = target.transform.position - mainCamera.transform.position;
        }
    }

    Camera mainCamera;
    ThirdPersonCamera thirdPersonCamera;
}
