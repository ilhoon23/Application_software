using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class realistic : MonoBehaviour
{
    public GameObject sun, mercury, venus, earth, moon, mars, jupiter, saturn, uranus, neptune;
    public int real;
    // Start is called before the first frame update
    void Start()
    {
        real = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Real = 0, unrealistic. Real = 1, realistic
        //Upon pressing r, switch between realistic, unrealistic mode
        if (real == 0 && Input.GetKeyDown(KeyCode.R))
        {
            real = 1;
            sun.transform.localScale = new Vector3(109, 109, 109);
            mercury.transform.localScale = new Vector3(0.38f, 0.38f, 0.38f);
            venus.transform.localScale = new Vector3(0.95f, 0.95f, 0.95f);
            moon.transform.localScale = new Vector3(0.27f, 0.27f, 0.27f);
            mars.transform.localScale = new Vector3(0.53f, 0.53f, 0.53f);
            jupiter.transform.localScale = new Vector3(11.2f, 11.2f, 11.2f);
            saturn.transform.localScale = new Vector3(9.45f, 9.45f, 9.45f);
            uranus.transform.localScale = new Vector3(4.0f, 4.0f, 4.0f);
            neptune.transform.localScale = new Vector3(3.88f, 3.88f, 3.88f);

            sun.transform.position = new Vector3(0, 0, 0);
            mercury.transform.position = new Vector3(0, 0, 119);
            venus.transform.position = new Vector3(0, 0, 126.5f);
            earth.transform.position = new Vector3(0, 0, 134);
            moon.transform.position = new Vector3(0, 0, 135);
            mars.transform.position = new Vector3(0, 0, 146.5f); ;
            jupiter.transform.position = new Vector3(0, 0, 234);
            saturn.transform.position = new Vector3(0, 0, 346.5f);
            uranus.transform.position = new Vector3(0, 0, 584);
            neptune.transform.position = new Vector3(0, 0, 859);

        }
        else if (real == 1 && Input.GetKeyDown(KeyCode.R))
        {
            real = 0;
            sun.transform.localScale = new Vector3(3, 3, 3);
            mercury.transform.localScale = new Vector3(1, 1, 1);
            venus.transform.localScale = new Vector3(1, 1, 1);
            moon.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            mars.transform.localScale = new Vector3(1, 1, 1);
            jupiter.transform.localScale = new Vector3(2, 2, 2);
            saturn.transform.localScale = new Vector3(2, 2, 2);
            uranus.transform.localScale = new Vector3(2, 2, 2);
            neptune.transform.localScale = new Vector3(2, 2, 2);

            sun.transform.position = new Vector3(0, 0, 0);
            mercury.transform.position = new Vector3(0, 0, 4);
            venus.transform.position = new Vector3(0, 0, 8);
            earth.transform.position = new Vector3(0, 0, 12);
            moon.transform.position = new Vector3(0, 0, 13);
            mars.transform.position = new Vector3(0, 0, 16); ;
            jupiter.transform.position = new Vector3(0, 0, 20);
            saturn.transform.position = new Vector3(0, 0, 24);
            uranus.transform.position = new Vector3(0, 0, 28);
            neptune.transform.position = new Vector3(0, 0, 32);

        }
        
    }
}
