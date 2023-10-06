using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontrol : MonoBehaviour

{
    public float speed = 10f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            if (SceneManager.GetActiveScene().name == "Level1")
            {
                SceneManager.LoadScene("Level2");
            }
            else
            {
                SceneManager.LoadScene("Level1");
            }
        }    }

    private void FixedUpdate()
    {
        rb.AddForce(Vector2.right * Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime, ForceMode2D.Impulse);
        rb.AddForce(Vector2.up * Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime, ForceMode2D.Impulse);
    }
}
