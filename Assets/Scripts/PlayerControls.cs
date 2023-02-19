using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Rigidbody2D rd;
    public KeyCode moveUp;
    public KeyCode moveDown;
    
    public float speed = 10;

    void Update()
    {
        if (Input.GetKey(moveUp))
        {
            rd.velocity = new Vector2(rd.velocity.y, speed);
        }
        else if (Input.GetKey(moveDown))
        {
            rd.velocity = new Vector2(rd.velocity.y, speed*-1);
        }
        else
        {
            rd.velocity = new Vector2(rd.velocity.y, 0);
        }

        
    }

}
