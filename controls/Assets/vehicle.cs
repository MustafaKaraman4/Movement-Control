using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class binek : MonoBehaviour

{
  

    Rigidbody2D bnk;
    Vector3 velocity;
          float speedAmount=0.7f;
          void Start(){
              bnk= GetComponent<Rigidbody2D>();
          }
    private void OnCollisionEnter2D(Collision2D collision) {
     if(collision.gameObject.tag.Equals("Player")) {
       
     velocity = new Vector3(5,0,0);
     
          
       
     
        
       bnk.AddForce(Vector3.right*speedAmount,ForceMode2D.Impulse);
        
      }
    }}