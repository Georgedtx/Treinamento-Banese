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
                Debug.Log("O m�s selecionado � janeiro");
                break;
            case 2:
                Debug.Log("O m�s selecionado � fevereiro");
                break;
            case 3:
                Debug.Log("O m�s selecionado � mar�o");
                break;
            default:
                Debug.Log("O m�s selecionado n�o � valido");
                break;
        }
    }
}
