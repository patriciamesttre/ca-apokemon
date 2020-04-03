using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyThis : MonoBehaviour
{

    DontDestroyThis[] itens;
    // Start is called before the first frame update
    void Start()
    {
        itens = FindObjectsOfType<DontDestroyThis>();
        if (itens.Length <= 1)
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
