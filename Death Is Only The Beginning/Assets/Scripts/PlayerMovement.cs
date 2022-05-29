using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] private float speed;
   private Rigidbody2D body;

   private void Awake() {
       body = GetComponent<Rigidbody2D>();
   }

   private void Update() {
       float HorizontalInput = Input.GetAxis("Horizontal");
       body.velocity = new Vector2(HorizontalInput * speed, body.velocity.y);

        // Flip player when moving left or right
       if(HorizontalInput > 0.01f)
       transform.localScale = Vector3.one;
       else if(HorizontalInput < -0.01f)
       transform.localScale = new Vector3(-1, 1, 1);

       if(Input.GetKey(KeyCode.Space)) 
        body.velocity = new Vector2(body.velocity.x, speed);
   }
}
