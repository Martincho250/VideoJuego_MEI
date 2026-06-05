using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float tiempoRestante = 60f;

    public TextMeshProUGUI textoTiempo;

    bool tiempoActivo = true;

    void Update()
    {
        if (tiempoActivo)
        {
            // Resta tiempo
            tiempoRestante -= Time.deltaTime;

            // Evita números negativos
            if (tiempoRestante <= 0)
            {
                tiempoRestante = 0;
                tiempoActivo = false;

                Debug.Log("Tiempo terminado");
            }

            // Actualiza texto
            textoTiempo.text = "Tiempo: " + Mathf.Ceil(tiempoRestante);
        }
    }
}