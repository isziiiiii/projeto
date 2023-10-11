using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int ForcaPulo = 100;
    Rigidbody rb;
   
    void Start()
    {
        TryGetComponent(out rb);   
    }
    public bool noChao;

     private void OnCollisionEnter (Collision collision){
        noChao = true;
     }
    // Update is called once per frame
    void Update()
    {
        //pulo
        if (noChao && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * ForcaPulo, ForceMode.Impulse);
          noChao = false;
    }
   }
}