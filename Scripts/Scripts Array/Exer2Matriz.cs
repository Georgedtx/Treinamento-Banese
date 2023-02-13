using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exer2Matriz : MonoBehaviour
{
    public bool ler;
    //1° - forma
    public string[,,] diasSemana1 = { {{ "1","Dom", "Domingo" }, { "2","Seg", "Segunda" }, { "3","Ter", "Terça" }, {"4",  "Qua" ,"Quarta"},
                                                         { "5","Qui", "Quinta" }, { "6","Sex", "Sexta" }, { "7","Sab", "Sabado" } }};

    // Start is called before the first frame update
    void Update()
    {
        if (ler)
        {
            for(int linha = 0; linha <= 0; linha++)
            {
                for(int coluna = 0; coluna <= 6; coluna++)
                {
                    for(int profundidade  = 0; profundidade < 3; profundidade++)
                    Debug.Log("Posição [" + linha + ", " + coluna +", "+ profundidade + "] -> "+ diasSemana1[linha, coluna, profundidade]);
                        
                }
            } 
            ler= false;
        }
    }
}