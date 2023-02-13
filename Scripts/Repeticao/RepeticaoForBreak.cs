using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeticaoForBreak : MonoBehaviour
{
    public int repeticoes = 30;

    // Update is called once per frame
    void Start()
    {
        for (int i = 0; i <= repeticoes; i++)
        {
            if (((float)(i) % 2) == 0)
            {
                Debug.Log(i + " é um numero par ");
            }
            else
            {
                break;
                Debug.Log(i + " é impar");
            }
        }
    }
}
