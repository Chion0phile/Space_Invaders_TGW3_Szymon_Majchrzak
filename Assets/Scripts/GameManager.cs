using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool EndGame = false;
    public bool WinGame = false;

    private void FixedUpdate()
    {
        if (EndGame)
        {
            Debug.Log("GameOver");
            EndGame = false;
        }
        if (WinGame)
        {
            Debug.Log("Win");
            WinGame = false;
        }
    }
}
