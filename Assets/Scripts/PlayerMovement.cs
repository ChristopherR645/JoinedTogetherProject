using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public GameObject gCube;
    public GameObject pCube;
    public Transform respawn;
    

    public float force;
    public float upForce;
    private float pushForce;
    private float uForce;


    private int x;

    private Rigidbody2D gMass;
    private Rigidbody2D pMass;

    public float lightMass;
    public float heavyMass;

    public Image charaterUI;
    public Sprite greenSprite;
    public Sprite pinkSprite;
    

    // Start is called before the first frame update
    void Start()
    {
        pushForce = force;
        uForce = upForce;
        

        x = 1;

        gMass = gCube.GetComponent<Rigidbody2D>();
        pMass = pCube.GetComponent<Rigidbody2D>();

        gMass.mass = lightMass;
        pMass.mass = lightMass;
        charaterUI.GetComponent<Image>().sprite = pinkSprite;
        

    }

     void Update() {
        //Respawn
        if (Input.GetKeyDown(KeyCode.R)) {

            Application.LoadLevel(Application.loadedLevel);
        }



        //Changes Which box to control x = 0 = Green, x = 1 = pink
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            if (x == 0) {
                x = 1;
                pMass.mass = lightMass;
                pCube.GetComponent<BoxMovement>().defaultColor();
                charaterUI.GetComponent<Image>().sprite = pinkSprite;
                Debug.Log(x);
            }
            else {
                x = 0;
                gMass.mass = lightMass;
                gCube.GetComponent<BoxMovement>().defaultColor();
                charaterUI.GetComponent<Image>().sprite = greenSprite;
                Debug.Log(x);
            }

        }


        //Changes Green square's mass
        if (Input.GetKeyDown(KeyCode.Space) && x == 1) {
            if (gMass.mass == lightMass) {
                gMass.mass = heavyMass;
                gCube.GetComponent<BoxMovement>().blueOrGreen();
                Debug.Log("Mass of green is 0.5");
            }
            else if (gMass.mass == heavyMass) {
                gMass.mass = lightMass;
                gCube.GetComponent<BoxMovement>().blueOrGreen();
                Debug.Log("Mass of green is 1");
            }

        }
        //Changes pink square's mass
        if (Input.GetKeyDown(KeyCode.Space) && x == 0) {
            if (pMass.mass == lightMass) {
                pMass.mass = heavyMass;
                pCube.GetComponent<BoxMovement>().blueOrGreen();
                Debug.Log("Mass of pink is 0.5");
            }
            else if (pMass.mass == heavyMass) {
                pMass.mass = lightMass;
                pCube.GetComponent<BoxMovement>().blueOrGreen();
                Debug.Log("Mass of pink is 1");
            }

        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        

        //Movement for Green
        if (Input.GetKey(KeyCode.A) && x == 0) {

            gCube.GetComponent<BoxMovement>().pushLeft(pushForce/4);
            

        }
        //Movement for Green
        if (Input.GetKey(KeyCode.D) && x == 0) {

            gCube.GetComponent<BoxMovement>().pushRight(pushForce/4);

        }
        if (Input.GetKey(KeyCode.W) && x == 0) {

            gCube.GetComponent<BoxMovement>().pushUp(upForce / 4);


        }
        if (Input.GetKey(KeyCode.S) && x == 0) {

            gCube.GetComponent<BoxMovement>().pushDown(upForce / 4);

        }
        //Movement for Pink
        if (Input.GetKey(KeyCode.A) && x == 1) {

            pCube.GetComponent<BoxMovement>().pushLeft(pushForce/4);

        }
        //Movement for Pink
        if (Input.GetKey(KeyCode.D) && x == 1) {

            pCube.GetComponent<BoxMovement>().pushRight(pushForce/4);

        }

        if (Input.GetKey(KeyCode.W) && x == 1) {

            pCube.GetComponent<BoxMovement>().pushUp(upForce / 4);


        }
        //Movement for Green
        if (Input.GetKey(KeyCode.S) && x == 1) {

            pCube.GetComponent<BoxMovement>().pushDown(upForce / 4);

        }
    }

    
    
}
