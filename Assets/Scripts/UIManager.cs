using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    int contador = 0;
    int tiempo = 0;

    // Referencia al texto UI
    public TextMeshProUGUI textoContador;


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
        }
    }
}
