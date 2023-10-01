using DG.Tweening;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviourSingleton<AudioManager>
{
    [SerializeField] private AudioMixer _mixer;
    [SerializeField] private AudioSource _audioSource;

    [Header("Audio Clips")]
    [SerializeField] private AudioClip _hookshotAsteroidClip;
    [SerializeField] private AudioClip _pickUpBadClip;
    [SerializeField] private AudioClip _deadClip;
    
    
    private Tween _cutoffTween;
    
    private void Start()
    {
        _mixer.SetFloat("Cutoff", 22000);
    }

    public void SetVolume(float volume)
    {
        _mixer.SetFloat("Volume", volume);
    }

    public void MakeCutoff()
    {
        _cutoffTween.Kill();
        _cutoffTween = _mixer.DOSetFloat("Cutoff", 800, 1f);
    }

    public void UndoCutoff()
    {
        _cutoffTween.Kill();
        _cutoffTween = _mixer.DOSetFloat("Cutoff", 22000, 1f);
    }

    public void PlayBadPickSound()
    {
        _audioSource.PlayOneShot(_pickUpBadClip);
    }
    public void PlayDeadSound()
    {
        _audioSource.PlayOneShot(_deadClip);
    }
}