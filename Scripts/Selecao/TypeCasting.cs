using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeCasting : MonoBehaviour
{
    int num = 123456789;
    float numero;



    // Start is called before the first frame update
    void Start()
    {
        // Conversão implicita 
        Debug.Log("Valor inicial: " + numero);

        numero = num;

        Debug.Log("Valor inicial: " + num);
        Debug.Log("Valor atual: " + numero);
        Debug.Log("Tipo de dado: " + num.GetType());
        Debug.Log("Tipo de dado: " + numero.GetType());

    }

}
