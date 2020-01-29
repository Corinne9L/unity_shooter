using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour

{
    public float m_speed = 1f;
    public float m_force = 50f;
    public Transform target;


    private void Awake()
    {
        Debug.Log("Awake appelé");
    }

    // Start is called before the first frame update
    void Start()
    {
        print("start appelée");
    }

    // Update is called once per frame
    private void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        //Vector3 direction = Vector3.zero;
        //Vector3 velocity = Vector3.zero;
        float lHoriz = Input.GetAxisRaw("Horizontal");
        float lVert = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(lHoriz, 0, lVert);
        rb.velocity = direction * m_speed * Time.deltaTime;

        Rigidbody rb1 = GetComponent<Rigidbody>();
        float rHoriz = Input.GetAxisRaw("right_X");
        float rVert = Input.GetAxisRaw("right_Y");
        Vector3 rotation = new Vector3(rHoriz, 0, rVert);
        rb.rotation = Quaternion.LookRotation(rotation, Vector3.up);

        //Cliquer sur la vue pour assigner des inputs
        //Debug.Log("update appelé");


        //    if (Input.GetKey(KeyCode.RightArrow))
        //    {
        //        Debug.Log("Droite");
        //        //transform.Translate(Vector3.right * Time.deltaTime * m_speed);   distance par frame
        //        //Vector3 position = rb.position;
        //        //Vector3 direction = Vector3.right;
        //        //Vector3 velocity = direction * m_speed * Time.deltaTime;
        //        //Vector3 newPosition = position + velocity;
        //        //rb.MovePosition(newPosition);

        //        rb.velocity = direction * m_speed; //plus simple, mais changer la vitesse (plus les mêmes ordres de grandeurs)
        //        //rb.AddForce(Vector3.right * m_force); //rajoute de la force à chaque appui de touche


        //    }


        //    if (Input.GetKey(KeyCode.LeftArrow))
        //    {
        //        Debug.Log("Gauche");
        //        //rb.velocity = velocity;
        //        direction += Vector3.left;
        //    }


        //    if (Input.GetKey(KeyCode.UpArrow))
        //    {
        //        Debug.Log("Up");
        //        //rb.velocity = velocity;
        //        direction += Vector3.up;

        //    }


        //    if (Input.GetKey(KeyCode.DownArrow))
        //    {
        //        Vector3 velocity = default;
        //        //Debug.Log("Down");
        //        rb.velocity = velocity;

        //    }






    }

    //private voidFixedUpdate()
      
        
           // Debug.Log;
        





}


