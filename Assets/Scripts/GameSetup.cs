using UnityEngine;

public class GameSetup : MonoBehaviour
{
    public Camera mainCamera;
    public BoxCollider2D topWall;
    public BoxCollider2D downWall;
    public BoxCollider2D leftWall;
    public BoxCollider2D rightWall;

    public Transform player01;
    public Transform player02;

    //Gunakan start jika tidak ada alasan untuk mengubah kodenya
    void Start()
    {
        //move each wall to its edge location:

        //Determine screen height and width
        float screenHeight = mainCamera.orthographicSize * 2.0f;
        float screenWidth = screenHeight * Screen.width / Screen.height;

        //Set wall positions and sizes
        topWall.transform.position = new Vector2(0, screenHeight / 1.82f);
        topWall.transform.localScale = new Vector2(screenWidth, 1);

        downWall.transform.position = new Vector2(0, -screenHeight / 1.82f);
        downWall.transform.localScale = new Vector2(screenWidth, 1);

        leftWall.transform.position = new Vector2(-screenWidth / 1.9f, 0);
        leftWall.transform.localScale = new Vector2(1, screenHeight);

        rightWall.transform.position = new Vector2(screenWidth / 1.9f, 0);
        rightWall.transform.localScale = new Vector2(1, screenHeight);

        Vector3 player01Position = player01.position;
        player01Position.x = mainCamera.ScreenToWorldPoint(new Vector3(75f, 0f, 0f)).x;
        player01.position = player01Position;

        Vector3 player02Position = player02.position;
        player02Position.x = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width - 75f, 0f, 0f)).x;
        player02.position = player02Position;

    }
}
