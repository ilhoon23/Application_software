using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sun_rotation : MonoBehaviour
{
    //realistic a;
    // Start is called before the first frame update
    GameObject planets;
    private int real;
    void Start()
    {
        //Find the game object Planets and assign to planets 
        planets = GameObject.Find("Planets");

    }

    // Update is called once per frame
    void Update()
    {
        //Bring var real from realistic script on Planets
        real = planets.GetComponent<realistic>().real;

        //Rotations according to the mode
        if (real == 0)
        {
            transform.Rotate(new Vector3(0, -30, 0) * Time.deltaTime);

        }
        else if (real == 1)
        {
            transform.Rotate(new Vector3(0, -0.8f, 0) * Time.deltaTime );
        }
    }
}
