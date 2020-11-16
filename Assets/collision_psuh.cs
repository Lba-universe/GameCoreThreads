using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_psuh : MonoBehaviour
{
    [SerializeField]
    private string TagTrigger="pusher";
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


    private void OnCollisionEnter2D(Collider2D collision)
    {
        Debug.Log("trigger");
        float x = gameObject.transform.position.x;
        float y = gameObject.transform.position.y;
        if (collision.gameObject.tag==TagTrigger && Input.GetKey("l") || Input.GetKey("d"))
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(10,0));
        else
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-10, 0));
    }

}
