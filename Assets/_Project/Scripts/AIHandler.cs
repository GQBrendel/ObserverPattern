using UnityEngine;

public class AIHandler : MonoBehaviour
{
    [SerializeField] private Actor _characterToBeDriven;

    private Command _jumpCommand = new JumpCommand();
    private Command _moveHorizontalCommand = new MoveHorizontalCommand();
    private float _moveDirection = 0f;
    private bool _moveRight;

    private void FixedUpdate()
    {
        HandleAI();
    }

    private void HandleAI()
    {
        if (_moveRight)
        {
            if (_moveDirection <= 1f)
            {
                _moveDirection += Time.fixedDeltaTime * 2f;
            }
            else
            {
                _moveRight = false;
            }
        }
        else
        {
             if (_moveDirection >= -1f)
            {
                _moveDirection -= Time.fixedDeltaTime * 2f;
            }
            else
            {
                _moveRight = true;
            }
        }
 
        if (Random.Range(0, 1000) > 990)
        {
            _jumpCommand.Execute(_characterToBeDriven);
        }
        _moveHorizontalCommand.Execute(_characterToBeDriven, _moveDirection);
    }
}