using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour {

    public GameObject target;

    void LateUpdate()
    {
        transform.LookAt(target.transform);
    }
}
