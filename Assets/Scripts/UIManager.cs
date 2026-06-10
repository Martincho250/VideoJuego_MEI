using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    int contador = 0;

    public TextMeshProUGUI textoContador;
    public int objetivo = 1;
    public GameManager gameManager;


    void Start()
    {
        textoContador.text = "Objetos: 0";

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            contador++;

            // Actualiza el texto
            textoContador.text = "Objetos: " + contador;

            Debug.Log("Objetos recolectados: " + contador);

            Destroy(other.gameObject);
            if (contador >= objetivo)
            {
                gameManager.Ganar();
            }
        }
    }
}
