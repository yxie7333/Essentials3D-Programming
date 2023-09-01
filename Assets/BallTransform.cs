using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
 
    public Vector3 rotateChange;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateChange);
        
    }

    void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.name.Contains("Puzzle"))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

        if (collision.gameObject.name.Contains("CubePuzzle"))
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
