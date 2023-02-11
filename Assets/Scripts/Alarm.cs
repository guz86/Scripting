using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Alarm : MonoBehaviour
{
    [SerializeField] private float _duration;

    private Coroutine _coroutine;
    private AudioSource _alarmSound;
    private float _targetVolume;
    private float _delta;

    private void Start()
    {
        _alarmSound = GetComponent<AudioSource>();
        _alarmSound.volume = 0;
        _delta = Time.deltaTime / _duration;
    }

    public void StartAlarm()
    {
        if (_coroutine != null) StopCoroutine(_coroutine);
        
        if (_alarmSound.isPlaying)
        {
            _targetVolume = 0f;
            _coroutine = StartCoroutine(ExitAlarm());
        }
        else
        {
            if (!_alarmSound.isPlaying) _alarmSound.Play();
            
            _targetVolume = 1f;
            _coroutine = StartCoroutine(EnterAlarm());
        }
    }

    private IEnumerator EnterAlarm()
    {
        while (Math.Abs(_alarmSound.volume - _targetVolume) > 0.001f)
        {
            _alarmSound.volume = Mathf.MoveTowards(_alarmSound.volume, _targetVolume,
                _delta);
            yield return null;
        }

        _alarmSound.volume = _targetVolume;
    }

    private IEnumerator ExitAlarm()
    {
        while (Math.Abs(_alarmSound.volume - _targetVolume) > 0.001f)
        {
            _alarmSound.volume = Mathf.MoveTowards(_alarmSound.volume, _targetVolume,
                _delta);
            yield return null;
        }

        _alarmSound.volume = _targetVolume;

        if (_alarmSound.isPlaying) _alarmSound.Stop();
    }
}