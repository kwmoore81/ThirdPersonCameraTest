using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour {

    public GameObject target;
   // GameObject cameraFocus;

    public float damping = 1;
    public Vector3 offset;
    
    void Start()
    {
      
        //offset = target.transform.position - transform.position;
       
    }

    void LateUpdate()
    {

        float currentAngle = transform.eulerAngles.y;
        float desiredAngle = target.transform.eulerAngles.y;
        float angle = Mathf.LerpAngle(currentAngle, desiredAngle, Time.deltaTime * damping);

        Quaternion rotation = Quaternion.Euler(0, angle, 0);
        transform.position = target.transform.position - (rotation * offset);

        transform.LookAt(target.transform);
    }
}
