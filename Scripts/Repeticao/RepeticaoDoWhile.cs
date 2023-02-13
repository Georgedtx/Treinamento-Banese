using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeticaoDoWhile : MonoBehaviour
{
    public int num, repeticoes;
    public bool pare = true;
    // Update is called once per frame
    void Update()
    {
        if (pare != true)
        {
            while (num <= 10)
            {
                if (((float)(num) % 2 == 0))
                {
                    Debug.Log(num + "é par");
                }
                else
                {
                    continue;
                }
                num++;
            }
        }else if (num == repeticoes)
        {
            num = 0;
        }
    }
}
