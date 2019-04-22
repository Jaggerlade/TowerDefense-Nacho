using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnded)
        {
            return;
        }
        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        gameEnded = true;
        print("Game Over");
    }
}
