using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColecoesAdd : MonoBehaviour
{
    public bool listar, add;

    public string nome;
    int contador;

    public Dictionary<int, string> alunos = new Dictionary<int, string>();



    private void Update()
    {
        if (add && nome != "")
        {
            contador++;

            alunos.Add(contador,nome);
            nome = "";

            add= false; 
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
