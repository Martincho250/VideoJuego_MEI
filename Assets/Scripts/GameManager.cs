using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float tiempoRestante = 60f;
    public bool jugando = true;
    public bool tiempoActivo = true;
    public UIManager uiManager;
    
    
    public void pararTiempo()
    {
        tiempoActivo = false;
        Time.timeScale = 0f;
    }
      public void Reiniciar()
    {
    Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    void Start()
    {
    Time.timeScale = 1f;
    jugando = true;
    uiManager = FindObjectOfType<UIManager>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
        Reiniciar(); 
        }
        if (tiempoActivo)
        {
 
            tiempoRestante -= Time.deltaTime;

  
            if (tiempoRestante <= 0)
            {
                tiempoRestante = 0;
                tiempoActivo = false;
                uiManager.Derrota();
            }

        }
        uiManager.UpdateTimer(tiempoRestante);
    }

}