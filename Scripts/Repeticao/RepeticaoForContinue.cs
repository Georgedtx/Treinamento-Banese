using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeticaoForContinue : MonoBehaviour
{
    public int repeticoes = 30;
    // Start is called before the first frame update
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
                continue;
                Debug.Log(i + " é impar");
            }
        }
    }

}
