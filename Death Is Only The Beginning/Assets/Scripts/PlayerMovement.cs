using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] private float speed;
   private Rigidbody2D body;
   private Animator anim;

   private void Awake() {
       //Grab references for rigidBody and animator object
       body = GetComponent<Rigidbody2D>();
       anim = GetComponent<Animator>();
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

    //Set animator parameter
    /* anim.SetBool("run", HorizontalInput != 0); */
   }
}
