using UnityEngine;

public class SideWalls : MonoBehaviour
{
    public AudioSource audioSource;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.name == "Ball")
        {
            audioSource.pitch = Random.Range(0.8f, 1.2f);
            audioSource.Play();

            string wallName = transform.name;
            GameManager.Score(wallName);

            //Reset bola, jika terkena side wall
            hitInfo.gameObject.SendMessage("ResetBall");
        }
        
    }
}
