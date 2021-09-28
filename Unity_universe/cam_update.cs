using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_update : MonoBehaviour
{   
    public GameObject earth;
    public GameObject sun;
    public int scene;
    public int real;

    // Start is called before the first frame update
    void Start()
    {
        //start of with scene 2, nonrealistic mode
        scene = 2;
        real = 0;
    }

    // Update is called once per frame
    void Update()
    {   

        //if r pressed, change mode, go to scene 2 for that mode.
        if (real==0 && Input.GetKeyDown(KeyCode.R))
        {
            real = 1;
            scene = 2;
            Debug.Log("View from front");
            Camera.main.orthographic = false;
            transform.position = new Vector3(900, 0, 0);
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else if(real == 1 && Input.GetKeyDown(KeyCode.R))
        {
            real = 0;
            scene = 2;
            Debug.Log("View from front");
            Camera.main.orthographic = false;
            transform.position = new Vector3(40, 0, 0);
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }

        //If scene is 4(earth view), change position of camera each frame to the earth
        if (scene==4)
        {
            transform.position = earth.transform.position;
        }

        //1 pressed, top view according to the mode with orthographic.
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            if (real == 1)
            {

                scene = 1;
                Debug.Log("View from top");
                Camera.main.orthographic = true;
                Camera.main.orthographicSize = 500;
                transform.position = new Vector3(0, 300, 0);
                transform.rotation = Quaternion.Euler(90, 0, 0);
               

            }
            else
            {
                scene = 1;
                Debug.Log("View from top");
                Camera.main.orthographic = true;
                Camera.main.orthographicSize = 35;
                transform.position = new Vector3(0, 20, 0);
                transform.rotation = Quaternion.Euler(90, 0, 0);

            }

        }
        //2 pressed, front view according to the mode.
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (real == 1)
            {
                scene = 2;
                Debug.Log("View from front");
                Camera.main.orthographic = false;
                transform.position = new Vector3(900, 0, 0);
                transform.rotation = Quaternion.Euler(0, -90, 0);


            }
            else
            {
                scene = 2;
                Debug.Log("View from front");
                Camera.main.orthographic = false;
                transform.position = new Vector3(40, 0, 0);
                transform.rotation = Quaternion.Euler(0, -90, 0);

            }
            
        }
        //3 pressed, view from the sun.
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            scene = 3;
            Debug.Log("View from the sun");
            Camera.main.orthographic = false;
            transform.position = sun.transform.position;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        //4 pressed, view from the earth.
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            scene = 4;
            Debug.Log("View from the earth");
            Camera.main.orthographic = false;
            transform.position = earth.transform.position;
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
        /*w, s, a, d : move forward, backward, left, right
        transform.up, transform.forward, transform.right instead of Vector3.up, Vector3.forward, Vector3.right,
        in order to move according to the direction of the view, not the x,y,z axis
        */
        else if (Input.GetKey(KeyCode.W))
        {   
            if(scene == 1)
            {
                transform.position += transform.up * 5 * Time.deltaTime;
            }
            else
            {
                transform.position += transform.forward * 5 * Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (scene == 1)
            {
                transform.position += transform.up * -5 * Time.deltaTime;
            }
            else
            {
                transform.position += transform.forward * -5 * Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
           
                transform.position += transform.right * -5 * Time.deltaTime;
            
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * 5 * Time.deltaTime;

        }
        //q, e : camera rotation to left, right. Differs according to the scene.
        else if (Input.GetKey(KeyCode.Q))
        {
            if (scene == 1)
            {
                transform.Rotate(new Vector3(0, 0, 20 * Time.deltaTime));
            }
            else
            {
                transform.Rotate(new Vector3(0, -20 * Time.deltaTime, 0));
            }
            
        }
        else if (Input.GetKey(KeyCode.E))
        {
            if (scene == 1)
            {
                transform.Rotate(new Vector3(0, 0, -20 * Time.deltaTime));
            }
            else
            {
                transform.Rotate(new Vector3(0, 20 * Time.deltaTime, 0));
            }
        }
        //Up, Down : move camera up, down. Doesn't work for scene 1, since orthographic
        else if (Input.GetKey(KeyCode.UpArrow))
        {

            transform.position += new Vector3(0,5,0) * Time.deltaTime;


        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {

            transform.position += new Vector3(0, -5, 0) * Time.deltaTime;


        }
    }

}
