using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    // 'Start' é chamado depois da primeira atualização de frame
    void Start()
    {
        
    }

    //'Update' é chamado uma vez a cada frame
    void Update()
    {
         // Move o veículo para frente
         transform.Translate(Vector3.forward * Time.deltaTime * speed);
         
    }
}
