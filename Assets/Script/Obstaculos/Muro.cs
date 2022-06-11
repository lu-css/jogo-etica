using UnityEngine;

// TODO: Repulsão

public class Muro : MonoBehaviour, IInteragible
{
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Interagir()
    {
        rb.AddForce(transform.right * 200f, ForceMode.Impulse);
        Destroy(gameObject, 2f);
    }
}
