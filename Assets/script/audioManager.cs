using UnityEngine;

public class audioManager : MonoBehaviour
{
    public AudioClip[] playlist;
    public AudioSource audioSource;
    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = playlist[index];
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            index++;
            if (index >= playlist.Length)
            {
                index = 0;
            }
            audioSource.clip = playlist[index];
            audioSource.Play();

        }
    }
}
