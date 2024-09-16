using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMenage : MonoBehaviour
{

public TextMeshProUGUI hud, MsgVitoria;
public int restantes;

    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<Moeda>().Length;

         hud.text = $"Moedas restantes:{restantes}";
    } 

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;

        if (restantes <= 0)
        {
            MsgVitoria.text
        }
    }

    
}
//Continuarrrr 15:40 no video 6/7