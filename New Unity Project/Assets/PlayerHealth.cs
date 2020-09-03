using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public string talkingpoint = "Health";
    public float health = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message: "Health");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
