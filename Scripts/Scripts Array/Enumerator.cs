using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumerator : MonoBehaviour
{
    public bool exibir; 

    enum diasSemana { Domingo, Segunda, Ter�a, Quarta, Quinta, Sexta, S�bado};

    // Update is called once per frame
    void Update()
    {
        if(exibir)
        {
            diasSemana dia = diasSemana.Ter�a;
            Debug.Log("Hoje � " + dia);
            exibir= false;
        }
    }
}
