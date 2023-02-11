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
            _coroutine = StartCoroutine(PlayAlarm());
        }
        else
        {
            _targetVolume = 1f;
            _coroutine = StartCoroutine(PlayAlarm());
        }
    }

    private IEnumerator PlayAlarm()
    {
        // SrartAlarm
        if (!_alarmSound.isPlaying) _alarmSound.Play();
        
        while (Math.Abs(_alarmSound.volume - _targetVolume) > 0.001f)
        {
            _alarmSound.volume = Mathf.MoveTowards(_alarmSound.volume, _targetVolume,
                _delta);
            yield return null;
        }
        _alarmSound.volume = _targetVolume;
        
        // ExitAlarm
        if (_alarmSound.volume == 0 && _alarmSound.isPlaying) _alarmSound.Stop();
    }
}