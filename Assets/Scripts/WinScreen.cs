using UnityEngine;
using UnityEngine.Networking;
using System.Collections;


public class WinScreen : NetworkBehaviour {

    public Transform canvas;
    public Transform canvasL;
    RPGCharacterControllerFREE RPGCCF;
    public void gameOver()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
          
                RPGCCF = GameObject.FindGameObjectWithTag("Player").GetComponent<RPGCharacterControllerFREE>();

                if (RPGCCF.score < 10)
                {
                    canvasL.gameObject.SetActive(true);
                    Time.timeScale = 0;
                }
                else
                {
                    canvas.gameObject.SetActive(true);
                    Time.timeScale = 0;
                }
            
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
