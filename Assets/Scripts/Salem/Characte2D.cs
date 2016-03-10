using UnityEngine;
using System.Collections;

public class Characte2D : MonoBehaviour {
    
    public float speed = 50f;
    public float jumpForce = 1000f;
    public float maxSpeed = 30f;

    public bool grounded;
    public bool canDobleJumping;    
    private Rigidbody2D _rb;
    private Animator _anim;


	void Awake () {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
	}

    void Update() {
        print(grounded);

        _anim.SetBool("grounded", grounded);
        _anim.SetFloat("speed", Mathf.Abs(_rb.velocity.x));

        if (Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetButtonDown("Jump")) {
            if (grounded)
            {
                _rb.AddForce(Vector2.up * jumpForce);
                canDobleJumping = true;
            }
            else {
                if (canDobleJumping) {
                    canDobleJumping = false;
                    _rb.velocity = new Vector2(_rb.velocity.x, 0);
                    //agustar para mejorar el doble salto
                    _rb.AddForce(Vector2.up * jumpForce / 1.3f);
                }
            }
        }

        /*//simple jump
        if (Input.GetButtonDown("Jump") && grounded)
        {
            _rb.AddForce(Vector2.up * jumpForce);
        }*/

    }
	
	void FixedUpdate () {

        Vector3 easeVelocity = _rb.velocity;
        easeVelocity.y = _rb.velocity.y;
        easeVelocity.z = 0.0f;
        //easeVelocity.x se modifica para agregar o sacar friccion en los movimientos del personaje
        easeVelocity.x *= 0.75f;

        if (grounded) {
            _rb.velocity = easeVelocity;
        }

        if (_rb.velocity.x > maxSpeed) {
            _rb.velocity = new Vector2(maxSpeed, _rb.velocity.y);
        }

        if (_rb.velocity.x < -maxSpeed)
        {
            _rb.velocity = new Vector2(-maxSpeed, _rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(Vector2.left * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(Vector2.right * speed);
        }
	
    }
}
