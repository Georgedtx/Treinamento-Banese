using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeCasting1 : MonoBehaviour
{
    int num = 123456789;
    float numero;
    long numLongo;
    float fracionario = 3.14159265359f;
    double fracionarioLongo;


    // Start is called before the first frame update
    void Start()
    {
        // Conversão implicita 

        numero = num;

        Debug.Log("Valor inicial: " + num);
        Debug.Log("Valor atual: " + numero);
        Debug.Log("Tipo de dado: " + num.GetType());
        Debug.Log("Tipo de dado: " + numero.GetType());

        Debug.Log("Valor inicial: " + numLongo);

        //conversão explicita 
        numLongo = (long)num;

        Debug.Log("Valor convertido: " + numLongo);
        Debug.Log("Tipo de dado: " + numLongo.GetType());

        fracionarioLongo = (double)fracionario;
        Debug.Log($"Valor convertido: {fracionario}");
        Debug.Log($"tipo de dado: {fracionarioLongo.GetType()}");

    }

}
