using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Player moving methods
public class Move2D_2nd : MonoBehaviour
{
    
    [SerializeField] float speed = 11f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         float horizontal = Input.GetAxis("Horizontal"); 
         float vertical = Input.GetAxis("Vertical");   
          Vector3 movementVector = new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime;
          transform.position += movementVector;
     //   if (Input.GetKeyDown(KeyCode.W) && transform.position.y < limiter)
      //      transform.position += new Vector3(0, 1, 0);
      //  if (Input.GetKeyDown(KeyCode.S) && transform.position.y > -limiter)
      //      transform.position += new Vector3(0, -1, 0);
      //  if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -limiter)
      //      transform.position += new Vector3(-1, 0, 0);
      //  if (Input.GetKeyDown(KeyCode.D) && transform.position.x < limiter)
       //     transform.position += new Vector3(1, 0, 0);
    }
}
