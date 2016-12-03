using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour
{

    public Transform canvas;

    public void pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 1;
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            pause();
        }
    }
}
