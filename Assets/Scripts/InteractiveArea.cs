using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class InteractiveArea : MonoBehaviour
{
    int contador = 0;
    private UIManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
     uiManager = FindObjectOfType<UIManager>();   
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            contador++;

            // Actualiza el texto
            uiManager.UpdateObjects(contador);

            Debug.Log("Objetos recolectados: " + contador);

            Destroy(other.gameObject);
           
        }
    }
}
