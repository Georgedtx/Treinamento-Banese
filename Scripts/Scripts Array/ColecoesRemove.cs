using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColecoesRemove : MonoBehaviour
{
    public bool listar, remover;

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
        if (remover)
        {
            alunos.Remove(indice);
            remover= false;
            indice=0;
        }

        if (listar)
        {
            foreach(string nome in alunos.Values)
            {
                Debug.Log(nome);
            }
            listar = false;
        }
    }
}
