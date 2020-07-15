using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private Actor _characterToBeDriven;
    private Command _buttonSpace = new JumpCommand();

    private void HandleInput()
    {
        _buttonSpace.Execute(_characterToBeDriven);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            HandleInput();
        }
    }
}