using UnityEngine;

public class PlayAudioOnAwake : MonoBehaviour
{
    [SerializeField] private AudioSfx _audioSfx;

    private void Awake()
    {
        _audioSfx.PlayAudio(gameObject);
    }
}
