using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerMovment : NetworkBehaviour
{

    public float movementSpeed = 10;
    public float turningSpeed = 60;

    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }
}