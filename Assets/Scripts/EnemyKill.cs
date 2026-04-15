using UnityEngine;

public class EnemyKill : MonoBehaviour
{
    public AudioClip destroySound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Enemy hit player!");

            audioSource.PlayOneShot(destroySound);
            Destroy(collision.gameObject);
        }
    }
}
