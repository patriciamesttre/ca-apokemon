using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Criador : MonoBehaviour
{

    public GameObject Pokemon;


    public void ChocaPokemon()
    {
        int quantidade = 3;
        for(int i= 0; i < quantidade; i++)
        {
            Vector3 pokemonPosicao = new Vector3(Random.Range(-6f, 6f), Random.Range(-3f, 3f), 0f);
            Instantiate(Pokemon, pokemonPosicao, Quaternion.identity);
        }
        
    }
   
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
