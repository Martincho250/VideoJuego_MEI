using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class InteractiveArea : MonoBehaviour
{
    int Objetos = 0;
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
            Objetos++;

            // Actualiza el texto
            uiManager.UpdateObjects(Objetos);

            Debug.Log("Objetos recolectados: " + Objetos);

            Destroy(other.gameObject);
           
        }
    }
}
