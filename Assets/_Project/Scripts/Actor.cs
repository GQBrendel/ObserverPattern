using UnityEngine;

public class Actor : MonoBehaviour
{
    [SerializeField] private CharacterController2D _characterController;
    [SerializeField] private float _moveSpeed = 40f;
    private float _horizontalMove;
    private bool _jump;

    private void Update()
    {
        _horizontalMove = Input.GetAxisRaw("Horizontal") * _moveSpeed;
    }

    private void FixedUpdate()
    {
        _characterController.Move(_horizontalMove * Time.fixedDeltaTime, false, _jump);
        _jump = false;
    }

    public void Jump()
    {
        _jump = true;
    }
}