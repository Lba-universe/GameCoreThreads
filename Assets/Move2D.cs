using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Player moving methods
public class Move2D : MonoBehaviour
{
    [SerializeField]
    float speed=10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("i"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("k"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("l"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("j"))
        {
            pos.x -= speed * Time.deltaTime;
        }
       

        transform.position = pos;
    }
}
