using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class ConnectedPlayersVar : NetworkBehaviour
{    
    [SyncVar]
    private int counter = 0;

    [Server]
    public void ProvisionPlayer(GameObject playerobject)
    {
        
        var player = playerobject.GetComponent<RPGCharacterControllerFREE>();
        if(player != null)
        {
            Debug.Log("Provisioning..");
            player.playerID = counter++;
        }
    }
}
