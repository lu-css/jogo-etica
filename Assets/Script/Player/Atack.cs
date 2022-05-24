using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack : MonoBehaviour
{
    void OnTriggerStay(Collider other){
        IInteragible interagible = other.gameObject.GetComponent<IInteragible>();

        if(interagible == null) return;         // Se não for interafível não faz nada

        // Debug.Log("Aperte E para interagir");

        if(!Input.GetKeyDown(KeyCode.E)) return; // Se não Clicou não faz nada

        interagible.Interagir();
    }
}
