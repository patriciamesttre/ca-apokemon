using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pokemon : MonoBehaviour
{

    public Sprite[] modelos;

    private SpriteRenderer sr;

    private Criador criador;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = modelos[Random.Range(0, modelos.GetLength(0))];
        criador = FindObjectOfType<Criador>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        criador.AumentarPontos();
        Destroy(gameObject);
    }
}
