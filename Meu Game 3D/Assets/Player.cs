using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    public Rigidbody rg
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("start") ;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update");
    }
}
