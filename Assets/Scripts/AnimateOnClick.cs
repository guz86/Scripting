using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimateOnClick : MonoBehaviour
{
    private Animator _animator;
    private static readonly int Alarm = Animator.StringToHash("Alarm");

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        _animator.SetTrigger(Alarm);
    }
}
 