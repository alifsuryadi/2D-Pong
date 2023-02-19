using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rd;
    public float ballSpeed = 100;


    void Start()
    {
        StartCoroutine(StartGame());
        
    }


    //Tambah kecepatan jika melambat
    private void Update()
    {
        float xVel = rd.velocity.x;
        if ( xVel < 18 && xVel > -18 && xVel != 0)
        {
            if( xVel > 0)
            {
                //rd.velocity.y = supaya sumbu y tidak berubah juga
                rd.velocity = new Vector2(Random.Range(20,22), rd.velocity.y);
            }
            else
            {
                rd.velocity = new (Random.Range(-22,-20), -rd.velocity.y);
            }
            //Debug.Log("Velocity before : " + xVel);
            //Debug.Log("Velocity after : " + rd.velocity.x);
        }
        
    }


    //WaitforSecond
    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(2);
        GoBall();
    }

    public void ResetBall()
    {

        rd.velocity = new Vector2(0,0);
        transform.position = new Vector3(0, 0, 0);

        StartCoroutine(StartGame());
        

    }

    public void GoBall()
    {
        float randomBall = Random.Range(0f, 2f);
        if(randomBall <= 1f)
        {
            rd.AddForce(new Vector2(ballSpeed, 10));
        }
        else
        {
            rd.AddForce(new Vector2(-ballSpeed, -10));
        }
    }
}
