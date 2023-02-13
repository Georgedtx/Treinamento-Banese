using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBola : MonoBehaviour
{
    public float velocidade;

    public float deslocamentoVertical, deslocamentoHorizontal;
    
    public float horizontalMin, horizontalMax, verticalMin, verticalMax;

    public float salto;

    // Start is called before the first frame update
    void Start()
    {
        horizontalMin = -14.5f;
        horizontalMax = 14.5f;
        verticalMin = -14.5f;
        verticalMax = 14.5f;
        this.transform.position = new Vector3(0f, 0.5f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        deslocamentoVertical = Input.GetAxis("Vertical") * velocidade;
        deslocamentoVertical *= Time.deltaTime;

        deslocamentoHorizontal = Input.GetAxis("Horizontal") * velocidade;
        deslocamentoHorizontal *= Time.deltaTime;

        salto = Input.GetAxis("Jump") * velocidade;
        salto *= Time.deltaTime;

        if (this.transform.position.z > verticalMax)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y ,verticalMax);
        }

        if (this.transform.position.z < verticalMin)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, verticalMin);

        }

        if (this.transform.position.x > horizontalMax)
        {
            this.transform.position = new Vector3(horizontalMax, this.transform.position.y, this.transform.position.z);
        }

        if (this.transform.position.x < horizontalMin)
        {
            this.transform.position = new Vector3(horizontalMin, this.transform.position.y, this.transform.position.z);

        }

        transform.Translate(deslocamentoVertical,salto, deslocamentoHorizontal);

    }
}
