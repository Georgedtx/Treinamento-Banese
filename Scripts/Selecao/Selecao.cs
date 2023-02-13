using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Selecao : MonoBehaviour
{

    public int mes;

    // Update is called once per frame
    void Update()
    {
        switch (mes)
        {
            case 1:
                Debug.Log("O mês selecionado é janeiro");
                break;
            case 2:
                Debug.Log("O mês selecionado é fevereiro");
                break;
            case 3:
                Debug.Log("O mês selecionado é março");
                break;
            default:
                Debug.Log("O mês selecionado não é valido");
                break;
        }
    }
}
