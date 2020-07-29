using UnityEngine;

public class UITopPanel : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void PlayAnimation()
    {
        _animator.SetTrigger("Play");
    }
}