using UnityEngine;

public class Atack : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        IInteragible interagible = other.gameObject.GetComponent<IInteragible>();

        if (interagible == null) return;

        if (!Input.GetKeyDown(KeyCode.E)) return;

        interagible.Interagir();

    }
}


