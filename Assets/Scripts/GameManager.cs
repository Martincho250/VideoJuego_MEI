using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float tiempoRestante = 60f;

    public TextMeshProUGUI textoTiempo;

    bool tiempoActivo = true;
    public GameObject panelVictoria;
    public GameObject panelDerrota;
    public GameManager gameManager;


    void Update()
    {
           if (Input.GetKeyDown(KeyCode.R))
    {
        Reiniciar();
    }
        if (tiempoActivo)
        {
 
            tiempoRestante -= Time.deltaTime;

  
            if (tiempoRestante <= 0)
            {
                tiempoRestante = 0;
                tiempoActivo = false;
                gameManager.Perder();
                Debug.Log("Tiempo terminado");
            }

            // Actualiza texto
            textoTiempo.text = "Tiempo: " + Mathf.Ceil(tiempoRestante);
        }
    }
      public void Ganar()
    {
        panelVictoria.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Perder()
    {
        panelDerrota.SetActive(true);
        Time.timeScale = 0f;
    }
    void Start()
    {
    Time.timeScale = 1f;
    }
    public void Reiniciar()
    {
    Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}