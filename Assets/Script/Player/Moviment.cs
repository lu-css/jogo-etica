using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    public float speed = 3f, runSpeed;
    float inputX;
    Vector3 direcao;

    void Update()
    {
        Walk();
    }
    

    void Walk(){
        inputX = Input.GetAxis("Horizontal"); // A D

        if (inputX == 0) return;

        direcao = new Vector3(inputX, 0, 0);

        float actualSpeed = speed;

        if (Input.GetKey(KeyCode.LeftShift)){
            actualSpeed = runSpeed;    
        }
        
        transform.Translate(0, 0, actualSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direcao), 5 * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }
}
