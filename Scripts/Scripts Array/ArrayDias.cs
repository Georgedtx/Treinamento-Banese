using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayDias : MonoBehaviour
{
    //1° - forma
    public string[] diasSemana1 = { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sab" };
    public bool ler;

    // Start is called before the first frame update
    void Update()
    {
        if (ler)
        {
            for (int linha = 0; linha < 7; linha++)
            {
                Debug.Log("Posição[" + linha + "] -> " + diasSemana1[linha]);
            }
            ler = false;
        }    
    }
}
