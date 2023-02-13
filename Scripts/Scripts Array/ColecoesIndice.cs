using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColecoesIndice : MonoBehaviour
{
    public bool listar;

    public string nome;
    int indice;

    public Dictionary<int, string> alunos = new Dictionary<int, string>()
    {
        { 1, "Susan"},
        { 2, "Yuri"},
        { 3, "Gustavo"},
        { 4, "George"},
        { 5, "Vinicius"},
        { 6, "Pedro"},
        { 7, "George Dantas"},
        { 8, "Laryssa"},
        { 9, "Leandro"},
        { 10, "Luca"},
        { 11, "André"},
        { 12, "Paulo"}
    };



    private void Update()
    {
        if (listar)
        {
            foreach(KeyValuePair<int, string> nome in alunos)
            {
                Debug.Log(nome.Key + " - " + nome.Value);
            }
            listar = false;
        }
    }
}
