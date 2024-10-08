using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour 
{
    public int velocidade = 10;
    public Rigidbody rb;
    public int forcaPulo = 10;
    public bool noChao = true;

    void Start()
    {
        Debug.Log("start");
        TryGetComponent(out rb);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if  ( !noChao && collision.gameObject.tag == "Chão")
        {
            noChao = true;
        }
    }

    void Update()
    {
        Debug.Log("update");
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        UnityEngine.Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
        if (Input.GetKeyDown(KeyCode.Space) && noChao == true)
        {
            rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
            noChao = false;

        }
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
         }
    }
}