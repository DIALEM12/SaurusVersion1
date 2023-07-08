using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDePausa : MonoBehaviour
{
    public GameObject pauseMenu;
    public void Pausa()
    {
        Debug.Log("pausa");
     pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Continuar()
    {
        Debug.Log("continuar");
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

}
