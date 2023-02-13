using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaInserir : MonoBehaviour
{
    public bool inserir;
    public int posicao;
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
        if (inserir)
        {
            alunos.Insert(posicao, nome);
            inserir = false;  
        }
    }
}
