using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muro : MonoBehaviour, IInteragible{
    Rigidbody rb;
    void Start(){
        rb = GetComponent<Rigidbody>();
    }
    public void Interagir(){
        Vector3 direcao = transform.forward;
        direcao.x *= -Mathf.Sqrt(Mathf.Pow(direcao.x,2));
        direcao.y /= 4;
        rb.AddForce(direcao * 200f, ForceMode.Impulse);
        // Destroy(gameObject, 2f);
    }
}