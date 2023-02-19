using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColoor : MonoBehaviour
{
    SpriteRenderer sr;
    public Color color;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = Color.red;
    }

    private void OnMouseUp()
    {
        sr.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey(KeyCode.UpArrow))
        // {
        //     transform.Translate(Vector3.up * Time.deltaTime * speed); // Time.deltaTime is the time between frames 
        // }
        // else if (Input.GetKey(KeyCode.DownArrow))
        // {
        //     transform.Translate(Vector3.down * Time.deltaTime * speed);
        // }

        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * hor * Time.deltaTime * speed);
        transform.Translate(Vector3.up * ver * Time.deltaTime * speed);
    }
}
