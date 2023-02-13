using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaArray : MonoBehaviour
{
    public bool converter;
    public int posicoes;
    public string[] nomeList;

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

    private void Start()
    {
        posicoes = alunos.Count;
        nomeList= new string[posicoes];
    }

    private void Update()
    {
        if (converter)
        {
            nomeList = alunos.ToArray();
            converter = false;  
        }
    }
}
