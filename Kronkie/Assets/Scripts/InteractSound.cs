using UnityEngine;

public class InteractSound : MonoBehaviour
{
    public AudioClip soundClip;
    public KeyCode interactKey = KeyCode.E;
    public float activationRadius = 5f;

    private AudioSource audioSource;
    private bool canInteract = true;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component not found on the GameObject.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(interactKey) && canInteract && IsPlayerNearby())
        {
            PlaySound();
            StartCoroutine(DelayInteraction());
        }
    }

    void PlaySound()
    {
        if (audioSource != null && soundClip != null)
        {
            audioSource.PlayOneShot(soundClip);
        }
    }

    bool IsPlayerNearby()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            float distance = Vector3.Distance(transform.position, player.transform.position);
            return distance <= activationRadius;
        }
        return false;
    }

    System.Collections.IEnumerator DelayInteraction()
    {
        canInteract = false;
        yield return new WaitForSeconds(1f);
        canInteract = true;
    }
}
