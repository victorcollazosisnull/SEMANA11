using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PLAYERCONTROL : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer;
    public float speed;
    public float xDireccion;
    public float yDireccion;
    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {        
        _rigidbody2D.velocity = new Vector2(speed * xDireccion, speed * yDireccion);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Horizontal")
        {
            xDireccion = xDireccion * -1;
            if (xDireccion == -1 && yDireccion == -1)
            {
                _spriteRenderer.flipX = true;
            }    
            if (xDireccion == 1 && yDireccion == 1)
            {
                _spriteRenderer.flipX = false;
            }
            if (xDireccion == 1 && yDireccion == -1)
            {
                _spriteRenderer.flipX = false;
            }
            if (xDireccion == -1 && yDireccion == 1)
            {
                _spriteRenderer.flipX = true;
            }
        }
        if (collision.gameObject.tag == "Vertical")
        {
            yDireccion = yDireccion * -1;
            if (yDireccion == -1 && xDireccion == 1)
            {
                _spriteRenderer.flipX = false;
            }
            if (yDireccion == -1 && xDireccion == -1)
            {
                _spriteRenderer.flipX = true;
            }
            if (yDireccion == 1 && xDireccion == -1)
            {
                _spriteRenderer.flipX = true;
            }
        }
    }
}
