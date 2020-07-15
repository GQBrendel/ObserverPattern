using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private Actor _characterToBeDriven;
    private Command _buttonSpace = new JumpCommand();
    private Command _buttonMoveHorizontal = new MoveHorizontalCommand();

    private void HandleInput()
    {
        _buttonMoveHorizontal.Execute(_characterToBeDriven, Input.GetAxisRaw("Horizontal"));

        if (Input.GetButtonDown("Jump"))
        {
            _buttonSpace.Execute(_characterToBeDriven);
        }
    }

    private void Update()
    {
        HandleInput();
    }
}