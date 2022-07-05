using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colission : MonoBehaviour
{
    [SerializeField] Color32 temPacoteCor = new Color32 (1,1,1,1);
    [SerializeField] Color32 semPacoteCor = new Color32 (1,1,1,1);
    [SerializeField] float delay = 0.4f;
    bool temPacote;
    SpriteRenderer spriteRenderer;
    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
       Debug.Log("bateu");  
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Entrega" && temPacote == false)
        {
            spriteRenderer.color = temPacoteCor;
            Destroy(other.gameObject,delay);
            temPacote = true;
            Debug.Log("pegou pacote"); 
        }  
        
        if(other.tag == "Cliente" && temPacote)
        {
            spriteRenderer.color = semPacoteCor;
            Debug.Log("entregou pacote"); 
            temPacote = false;
        } 
    }
}
