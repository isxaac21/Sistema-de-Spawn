using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ui : RandomSpawner
{
    public TextMeshProUGUI posiciontext;
    public TextMeshProUGUI tiempo;
    public RandomSpawner RandomSpawner;
    public TextMeshProUGUI Ultimo;


    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        posiciontext.text = "Numero de Objetos: " + RandomSpawner.contador;
        tiempo.text = "tiempo de aparicion entre objetos: " + RandomSpawner.time;
        if (RandomSpawner.UltimoObjeto != null)
        {
            Ultimo.text = "Posicion Ultimo objeto" + RandomSpawner.UltimoObjeto.transform.position;
        }
    }
}
