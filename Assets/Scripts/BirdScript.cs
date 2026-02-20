using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public float flapStrength;
    public Rigidbody2D myRigidBody;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public bool isGamePaused = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0) && birdIsAlive == true)
        {
            myRigidBody.linearVelocityY = flapStrength;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (isGamePaused)
            {
                logic.resume();
                isGamePaused = false;
            }
            else
            {
                logic.pauseScreen();
                isGamePaused = true;
            }
            

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
