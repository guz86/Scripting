using UnityEngine;

public class AnimateOnClick : MonoBehaviour
{
    private Animator _animator;
    private static readonly int Alarm = Animator.StringToHash("Alarm");

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        _animator.SetTrigger(Alarm);
    }
}
 