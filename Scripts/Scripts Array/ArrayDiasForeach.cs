using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayDiasForeach : MonoBehaviour
{
    //1° - forma
    public string[] diasSemana1 = { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sab" };
    public bool ler;

    // Start is called before the first frame update
    void Update()
    {
        if (ler)
        {
            int i = 1;

            foreach (string dia in diasSemana1)
            {
                Debug.Log("Posição ["+ i++ +"] -> "+dia);
            }
            ler = false;
        }    
    }
}
