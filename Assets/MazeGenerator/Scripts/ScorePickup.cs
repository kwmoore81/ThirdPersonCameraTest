using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class ScorePickup : NetworkBehaviour
{
    int value = 1;

    void OnTriggerEnter(Collider other)
    {
        var player =  other.GetComponent<RPGCharacterControllerFREE>();
        if(player != null)
        {
            if (isServer)
            {
                // give points!
                player.score += value;

                // destroy for all connected players
                NetworkServer.Destroy(gameObject);
            }
        }
    }
}
