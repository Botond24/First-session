using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ludiq;
using Bolt;

public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    public void Exit()
    {
        Application.Quit();
    }
    public void Restart()
    {
        Variables.Application.Set("Is_Running", 1);
        gameOver.SetActive(false);
    }
}
