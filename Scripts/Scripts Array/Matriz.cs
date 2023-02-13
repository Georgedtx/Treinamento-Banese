using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matriz : MonoBehaviour
{
    //1° - forma
    public string[,] diasSemana1 = { { "Dom", "Domingo" }, { "Seg", "Segunda" }, { "Ter", "Terça" }, { "Qua" ,"Quarta"}, 
                                                         { "Qui", "Quinta" }, { "Sex", "Sexta" }, { "Sab", "Sabado" } };

    //2° - forma
    public string[,] diasSemana2 = new string[7,2] { { "Dom", "Domingo" }, { "Seg", "Segunda" }, { "Ter", "Terça" }, { "Qua" ,"Quarta"},
                                                         { "Qui", "Quinta" }, { "Sex", "Sexta" }, { "Sab", "Sabado" } };

    //3° - forma 
    public string[,] diasSemana3;


    // Start is called before the first frame update
    void Start()
    {
        diasSemana3 = new string[7,2];

        diasSemana3[0,0] = "Dom";
        diasSemana3[0, 1] = "Domingo";
        diasSemana3[1,0] = "Seg";
        diasSemana3[1, 1] = "Segunda";
        diasSemana3[2,0] = "Ter";
        diasSemana3[2, 1] = "Terça";
        diasSemana3[3,0] = "Qua" ;
        diasSemana3[3, 1] = "Quarta";
        diasSemana3[4,0] =  "Qui";
        diasSemana3[4, 1] = "Quinta";
        diasSemana3[5,0] = "Sex";
        diasSemana3[5, 1] = "Sexta";
        diasSemana3[6,0] = "Sab";
        diasSemana3[6, 1] = "Sabado";

    }
}
