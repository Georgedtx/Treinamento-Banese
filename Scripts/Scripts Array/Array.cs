using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    //1° - forma
    public string[] diasSemana1 = { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sab" };

    //2° - forma
    public string[] diasSemana2 = new string[7] { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado" };

    //3° - forma 
    public string[] diasSemana3;


    // Start is called before the first frame update
    void Start()
    {
        diasSemana3 = new string[7];
        diasSemana3[0] = "Domingo";
        diasSemana3[1] = "Segunda-feira";
        diasSemana3[2] = "terça-feira";
        diasSemana3[3] = "Quarta-feira";
        diasSemana3[4] = "Quinta-feira";
        diasSemana3[5] = "Sexta-feira";
        diasSemana3[6] = "Sabado";

    }
}
