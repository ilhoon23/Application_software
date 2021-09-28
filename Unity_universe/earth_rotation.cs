using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth_rotation : MonoBehaviour
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
        if (real==0)
        {
            transform.RotateAround(Vector3.zero, Vector3.up, 10 * Time.deltaTime);
            transform.Rotate(new Vector3(0, -30, 0) * Time.deltaTime);

        }
        else if (real==1)
        {
            transform.RotateAround(Vector3.zero, Vector3.up, 10 * Time.deltaTime);
            transform.Rotate(new Vector3(0, -20, 0) * Time.deltaTime);

        }
    }
}
