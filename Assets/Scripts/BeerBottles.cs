using UnityEngine;

public class BeerBottles : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;
    public static int life = 3;
    public static int TotalScore = 0;
    float speed;
    public TextView Output;
    public static int point;
    private Rigidbody2D bottle;
    private Vector2 screenBounds;

    void Start()
    {
        bottle = this.GetComponent<Rigidbody2D>();
        speed = Random.Range(minSpeed, maxSpeed);
        bottle.velocity = new Vector2(0, -speed);
        switch (bottle.name)
        {
            case "Larue(Clone)":
                point = 1;
                break;
            case "Bud(Clone)":
                point = 2;
                break;
            case "Ken(Clone)":
                point = 3;
                break;
        }
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void Update()
    {
        //transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.y < (screenBounds.y - 1) * -1)
        {
            life -= 1;
            print($"You have {life} hearts left");
            if (life == 0)
            {
                SceneManaging.GameOver();
            }
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D hitObject)
    {
        if (hitObject.tag == "Player")
        {
            TotalScore += point;
            Destroy(this.gameObject);
        }
    }
}
