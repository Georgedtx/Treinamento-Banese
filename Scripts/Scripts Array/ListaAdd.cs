using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaAdd : MonoBehaviour
{
    public bool add;

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
        if (add)
        {
            alunos.Add(nome);
            add = false;  
        }
    }
}
