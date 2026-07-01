using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    int contador = 0;

    public TextMeshProUGUI textoCronometro;
    public TextMeshProUGUI textoPuntos;
    public TextMeshProUGUI textoVictoria;
    public TextMeshProUGUI textoDerrota;
    public TextMeshProUGUI textoSub;
    public GameObject panelVictoria;
    public GameObject panelDerrota;
    public GameManager gameManager;


    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    public void UpdateTimer (float tiempo)
    { 
        textoCronometro.text = tiempo.ToString("F2");
    }
    public void Derrota(){ 
        textoPuntos.text = "";
        gameManager.jugando = false;
        Time.timeScale = 0;
        panelDerrota.SetActive(true);
    }
    public void UpdateObjects(int Objetos){
        if(Objetos < 5)
        {
        textoPuntos.text = "Objetos:" + Objetos;
        }
        else { 
            textoPuntos.text = "";
            gameManager.jugando = false;
            Time.timeScale = 0;
            panelVictoria.SetActive(true);
        }
     }

}
