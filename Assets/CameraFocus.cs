using UnityEngine;
using System.Collections;

public class CameraFocus : MonoBehaviour {

    Camera mainCamera;
    ThirdPersonCamera thirdPersonCamera;
    public GameObject self;

    // Use this for initialization
    void Start () {
        
        thirdPersonCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<ThirdPersonCamera>();
        thirdPersonCamera.target = gameObject;
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

        thirdPersonCamera.offset = gameObject.transform.position - mainCamera.transform.position;
        
    }
	
	
}
