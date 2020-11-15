using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Player moving methods
public class Move2D : MonoBehaviour
{
    [SerializeField]
    float limiter=1000;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y< limiter)
            transform.position += new Vector3(0, 1, 0);
        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > -limiter)
            transform.position += new Vector3(0, -1, 0);
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -limiter)
            transform.position += new Vector3(-1, 0, 0);
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < limiter)
            transform.position += new Vector3(1, 0, 0);
    }
}
