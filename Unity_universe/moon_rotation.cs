using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moon_rotation : MonoBehaviour
{
    GameObject planets;
    public GameObject earth;
    private int real;
    // Start is called before the first frame update
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
            transform.RotateAround(earth.transform.position, Vector3.up, 120 * Time.deltaTime);

        }
        else if (real == 1)
        {
            transform.RotateAround(earth.transform.position, Vector3.up, 120 * Time.deltaTime);
        }
    }
}
