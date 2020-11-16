using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision_destroy : MonoBehaviour
{
    [SerializeField]
    private string De="De";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == De)
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            SceneManager.LoadScene(0);
    }
}
