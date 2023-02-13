using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBall : MonoBehaviour
{
    public float velocidade = 20;
    public float deslocamentoVertical , deslocamentoHorizontal ;

    public float salto;

    public Vector3 movimento;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(0f, 0.5f, 0f);

        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        deslocamentoHorizontal = Input.GetAxis("Horizontal")* velocidade;
        deslocamentoHorizontal *= Time.deltaTime;

        deslocamentoVertical = Input.GetAxis("Vertical") * velocidade;
        deslocamentoVertical *= Time.deltaTime;

        salto = Input.GetAxis("Jump") * velocidade;
        salto *= Time.deltaTime;


        movimento = new Vector3(deslocamentoHorizontal, salto, deslocamentoVertical);
        movimento.Normalize();

        rb.AddForce(movimento*velocidade);
    }
}
