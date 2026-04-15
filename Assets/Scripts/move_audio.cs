using UnityEngine;

public class move_audio : MonoBehaviour
{
    public float speed = 5f;
    public AudioClip coinSound;

    private AudioSource audioSource;
    private int coinCount = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Debug.Log("Game Started");
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(h * speed * Time.deltaTime, 0, v * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            coinCount++;
            Debug.Log("Coin collected! Total coins: " + coinCount);

            audioSource.PlayOneShot(coinSound);
            Destroy(collision.gameObject);
        }
    }
}
