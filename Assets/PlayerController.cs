
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float MovementSpeed = 4.5f;
	public float JumpForce = 3.5f;


	private Rigidbody2D _rigidbody;
 
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        var movement = Input.GetAxis("Horizontal"); 
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        if (Input.GetButtonDown("Jump")) {
        	_rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}
