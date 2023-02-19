using UnityEngine;


public class BallCollision : MonoBehaviour
{
    public BallControl Ball;

    public AudioSource audioSource;
    //OnCollisionEnter = berarti hanya di panggil sekali
    private void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        //|| = atau
        if (collisionInfo.collider.tag == "Player")
        {
            Ball.rd.velocity = new Vector2(Ball.rd.velocity.x, Ball.rd.velocity.y / 2 + collisionInfo.collider.GetComponent<Rigidbody2D>().velocity.y / 3);
            
            //Bikin random pitchnya atau ketebalan suaranya
            audioSource.pitch = Random.Range(0.8f, 1.2f);
            audioSource.Play();
        }

    }

}
