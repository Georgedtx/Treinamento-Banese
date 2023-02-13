using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumerator : MonoBehaviour
{
    public bool exibir; 

    enum diasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};

    // Update is called once per frame
    void Update()
    {
        if(exibir)
        {
            diasSemana dia = diasSemana.Terça;
            Debug.Log("Hoje é " + dia);
            exibir= false;
        }
    }
}
