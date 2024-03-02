using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.InputSystem;
using TMPro;
public class playercontroller : MonoBehaviour
{
    public bool isonground=true;
    public float speed=0;
    private float horizontalInput;
    private float ForwardInput;
   // public int maxPlatform=0;
    public TextMeshProUGUI counttext;
    public GameObject wintextobject;
    public GameObject youlostobject;
    //public gameoverscreen gameoverscreen;
//public float JumpSpeed;
    private int count; // the game needs to start the game with count=0
    private Rigidbody rb;
    //private float movementX;
  //  private float movementY;

   // private float movementz;
    //jump:
    //public float jumph;
    public float jumpforce;
    //private Vector3 Jump;



    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        count=0; 
        SetCountText(); 
        wintextobject.SetActive(false);
        youlostobject.SetActive(false);
     //   Jump = new Vector3(0f,jumph,0f);
        
    }

    void Update()
    {
        horizontalInput=Input.GetAxis("Horizontal");
        ForwardInput=Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward *Time.deltaTime *speed*ForwardInput);
         transform.Translate(Vector3.right *Time.deltaTime *speed*horizontalInput);
if (Input.GetKeyUp (KeyCode.Space) && isonground)
  {
       rb.AddForce(Vector3.up *jumpforce, ForceMode.Impulse);
       isonground=false;
    }
    }

    private void OnCollisionEnter(Collision col)
{
     if (col.collider.tag==("COLLIDE"))
    {
        Youlosttext();
           //Time.timeScale = 0;
         
      //  gameoverscreen.Setup(maxPlatform);
      //  Application.Quit();
    }
    if (col.gameObject.CompareTag("Onground"))
    {
        isonground=true;
      //  gameoverscreen.Setup(maxPlatform);
      //  Application.Quit();
    }

}
  /*  private void Update()
    {
        

        }
    }
    /*
Vector's are mathematical models that model both direction and magnitude. A Vector2 is 2D, and a Vector3 3D.

A vector2(1,5) is a direction with the ratio of 1 part x, and 5 parts y. E.G a line 1/6th to the right, and 5/6th's up. a negative would make the line left and down respectively.

Magnitude show's the "strength" of the direction. E.g when using forces and physics, pushing something in a vector2(1,0) is a much weaker push to the right than a vector2(100,0).

That should be a basic theory introduction for you.

    */

  //  void OnMove(InputValue movementValue) 
      // {
      //  Vector2 movementVector =movementValue.Get<Vector2>();
       // movementX = movementVector.x;
       // movementY = movementVector.y;
       // movementz = movementVector.z;
    //}
     
     //public void jump(InputAction.CallbackContext context)
    // {

     //}


    void SetCountText()
    {
        counttext.text= "Score:"+count.ToString();
        if(count >= 17)
        {//Time.timeScale = 0;
            wintextobject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
          if (Input.GetKeyDown(KeyCode.Escape))
        {
           Application.Quit();
        }
        
        }
        
    }
    void Youlosttext()
    { 
            youlostobject.SetActive(true);
         //  Time.timeScale=0;
            if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           Application.Quit();
        }
    }


  //  void FixedUpdate()
    //{
       // Vector2 movement = new Vector2 (movementX, 0.0f , movementY);
      //  Vector3 Jump= new Vector3(0.0f, movementz, 0.0f);
      //  rb.AddForce(movement * speed);
        //rb.AddForce(Jump * speed);
        // if (Input.GetKeyUp (KeyCode.Space)) 
  //  {
    //    JumpSpeed = 5.0f;
        //Vector3 jump = new Vector3 (0.0f, movementz, 0.0f);
   // }

    //}
private void OnTriggerEnter(Collider other)//decativate collide of other gameobject
{
    if (other.gameObject.CompareTag("PickUp"))
    {
        other.gameObject.SetActive(false); // deactivating the game object
        count = count +1;
        SetCountText();
    }
    if (other.gameObject.CompareTag("PickUp2"))
    {
        other.gameObject.SetActive(false); // deactivating the game object
        count = count +2;
        SetCountText();
    }
    if (other.gameObject.CompareTag("PickUp3"))
    {
        other.gameObject.SetActive(false); // deactivating the game object
        count = count +3;
        SetCountText();
    }
   
    
}




//public void Gameover()
//{
  //  gameoverscreen.Setup(maxPlatform);
//}
}