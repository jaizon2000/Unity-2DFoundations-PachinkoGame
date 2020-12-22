using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RandomXPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // get random X float num from -8 to 8
        float newXPos = Random.Range(-8.0f, 8.0f);
        
        // Positon of object
        var position = transform.position;
        
        // --> Before positon 
        Debug.Log(position);

        // get the Input from Vertical axis
        float verticalInput = position.y;
        
        // Change position
        position = new Vector2(newXPos, verticalInput);
        transform.position = position;

        // --> After position
        Debug.Log(position);
    }

    // Update is called once per frame
    void Update()
    {
    }
}