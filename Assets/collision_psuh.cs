using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_psuh : MonoBehaviour
{
    [SerializeField]
    private string TagTrigger;
    bool flag = false;
    [SerializeField]
    int space = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!flag)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.left * 1000f*space* (transform.position.y * 10000));
            space = space* space;
        }
        if (flag)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.right * 1000f* space*(transform.position.y*10000));
            space = space * space;
        }

    }

}
