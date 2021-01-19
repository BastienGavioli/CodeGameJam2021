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
            audioSource.clip = playlist[index];
            audioSource.Play();
            if (index == 2)
            {
                index = 0;
            }
        }
    }
}
