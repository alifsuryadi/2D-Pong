using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static int playerScore01 = 0;
    public static int playerScore02 = 0;

    public GUISkin theSkin;

    public Transform theBall;

    private void Start()
    {
        theBall = theBall.gameObject.transform;
    }

    public static void Score(string wallName)
    {
        if(wallName == "rightWall")
        {
            playerScore01 += 1;
        }
        else
        {
            playerScore02 += 1;
        }
        Debug.Log("Player Score 1 is : " + playerScore01);
        Debug.Log("Player Score 2 is : " + playerScore02);
    }

    public void OnGUI()
    {
        GUI.skin = theSkin;

        //Rect = lebar layar, tinggi layar, lebar gambar, tinggi gambar
        GUI.Label(new Rect(Screen.width / 2 - 150 - 22, 25, 100, 100 ), "" + playerScore01);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 25, 100, 100 ), "" + playerScore02);

        if(GUI.Button ( new Rect (Screen.width / 2 - 121/2, 35, 121, 53), "RESET"))
        {
            playerScore01 = 0;
            playerScore02 = 0;

            theBall.gameObject.SendMessage("ResetBall");
        }
    }
}
