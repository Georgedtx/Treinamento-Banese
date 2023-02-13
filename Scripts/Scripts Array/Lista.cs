using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lista : MonoBehaviour
{
    public bool listar;

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
        if (listar)
        {
            foreach(string nome in alunos)
            {
                Debug.Log(nome);
            }
            listar = false;  
        }
    }
}
