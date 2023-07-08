using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausaMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public void pausa()

    {
        Debug.Log("pausa");
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;


    }
    public void continua()

    {
        Debug.Log("continuar");
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;


    }
}
