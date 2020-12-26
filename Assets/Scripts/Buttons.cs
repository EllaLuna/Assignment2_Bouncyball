using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void ReplayGame()
    {  
        SceneManager.LoadScene("BouncyBall");
        Physics2D.gravity = new Vector2(0, -9.81f);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
