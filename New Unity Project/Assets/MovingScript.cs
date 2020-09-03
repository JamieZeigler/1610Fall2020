using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{
    public float speed = 5f;
    public int score = 100;
    public string playerName = "Player";
    public string password = "WASD123";

    private void Update()
    {
        var hInput = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        var vInput = speed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Translate(hInput,vInput,0);
    }

    public void Up()
    {
        transform.Translate(0,speed,0);
    }

    public void Down()
    {
        transform.Translate(0,-speed,0);
    }
    
    public void Right()
    {
        transform.Translate(speed,0,0);
    }
    
    public void Left()
    {
        transform.Translate(-speed,0,0);
    }
    
}
