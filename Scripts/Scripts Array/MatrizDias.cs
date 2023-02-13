using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrizDias : MonoBehaviour
{
    public bool ler;
    //1° - forma
    public string[,] diasSemana1 = { { "Dom", "Domingo" }, { "Seg", "Segunda" }, { "Ter", "Terça" }, { "Qua" ,"Quarta"}, 
                                                         { "Qui", "Quinta" }, { "Sex", "Sexta" }, { "Sab", "Sabado" } };

    // Start is called before the first frame update
    void Update()
    {
        if (ler)
        {
            for(int linha = 0; linha <= 6; linha++)
            {
                for(int coluna = 0; coluna <= 1; coluna++)
                {
                    Debug.Log("Posição [" + linha + ", " + coluna + "] -> "+ diasSemana1[linha, coluna]);
                        ;
                }
            } 
            ler= false;
        }
    }
}
