using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rgb;
    public TextMeshProUGUI skortext;
Vector3 velocity;
public int skor;
float speedAmount=5f;
float jumpAmount=5f;
    
    void Start()
    {
        
rgb=GetComponent <Rigidbody2D>();
skor=0;
    }

    void Update()
    {
        skortext.text="Skor="+skor.ToString();
        velocity = new Vector3(Input.GetAxis("Horizontal"),0f);
        
        transform.position += velocity * speedAmount * Time.deltaTime;
       
        if(Input.GetButtonDown("Jump") && Mathf.Approximately(rgb.velocity.y,0)){

            rgb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
        }
    }
    



}
     