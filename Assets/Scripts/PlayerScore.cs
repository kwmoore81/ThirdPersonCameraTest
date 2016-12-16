using UnityEngine;
using System.Collections;

public class PlayerScore : MonoBehaviour {
   
    public GUIText scoreText;
   
    public void AddScore(int score)
    {      
        scoreText.text = "COINS: " + score; 
    }
  
}
