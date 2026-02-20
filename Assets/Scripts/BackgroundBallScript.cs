using UnityEngine;

public class BackgroundBallScript : MonoBehaviour
{
    public float DeadZoneRight = 75f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(
            new Vector2(5, 0),
            ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > DeadZoneRight)
        {
            Debug.Log("pipe deleted");
            Destroy(gameObject);
        }


    }

}
