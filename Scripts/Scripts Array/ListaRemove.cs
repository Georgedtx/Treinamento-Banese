using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaRemove : MonoBehaviour
{
    public bool remover;

    public string nome;

    public List<string> alunos = new List<string>()
    {
        { "Susan"},
        { "Yuri"},
        {  "Gustavo"},
        {  "George"},
        { "Vinicius"},
        { "Pedro"},
        { "George Dantas"},
        { "Laryssa"},
        { "Leandro"},
        {  "Luca"},
        { "André"},
        {  "Paulo"}
    };



    private void Update()
    {
        if (remover)
        {
            alunos.Remove(nome);
            remover = false;  
        }
    }
}
