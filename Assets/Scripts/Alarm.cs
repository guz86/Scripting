using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Alarm : MonoBehaviour
{
    [SerializeField] private float _delta;
    [SerializeField] private float _runningTime;
    [SerializeField] private float _duration;
    [SerializeField] private float _startVolume;
    [SerializeField] private float _targetVolume;
    private Coroutine _coroutine;

    private AudioSource _alarmSound;


    private void Start()
    {
        _alarmSound = GetComponent<AudioSource>();
    }

    public void StartAlarm()
    {
        if (_alarmSound.isPlaying)
        {
            Debug.Log(" _alarmSound.isPlaying ");
            if (_coroutine != null)
            {
                StopCoroutine(_coroutine);
            }
            _coroutine = StartCoroutine(ExitAlarm());
            
        }
        else
        {
            Debug.Log("! _alarmSound.isPlaying ");
            if (_coroutine != null)
            {
                StopCoroutine(_coroutine);
            }
            _coroutine = StartCoroutine(EnterAlarm());
        }
    }

    private IEnumerator EnterAlarm()
    {
        Debug.Log("EnterAlarm()");
        _alarmSound.volume = 0;
        _runningTime = 0;

        
        if (!_alarmSound.isPlaying)
        {
            _alarmSound.Play();
        }
        
        while (_runningTime <= _duration)
        {
            _runningTime += Time.deltaTime;
            float _delta = _runningTime / _duration;
            _alarmSound.volume = Mathf.MoveTowards(_startVolume, _targetVolume,
                _delta);
            yield return null;
        }
        Debug.Log("END EnterAlarm()");
    }

    private IEnumerator ExitAlarm()
    {
        Debug.Log("ExitAlarm()");
        _runningTime = 0;

        while (_runningTime <= _duration)
        {
            _runningTime += Time.deltaTime;
            float _delta = _runningTime / _duration;
            _alarmSound.volume = Mathf.MoveTowards(_targetVolume, _startVolume,
                _delta);
            yield return null;
        }

        if (_alarmSound.isPlaying)
        {
            _alarmSound.Stop();
        }
        Debug.Log("END ExitAlarm()");
    }
   
}