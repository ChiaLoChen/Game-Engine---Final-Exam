using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Player _player;
    private Command _up, _down, _left, _right, _shoot;
    // Start is called before the first frame update
    void Start()
    {
        _player = FindObjectOfType<Player>();
        _up = new Up(_player);
        _left = new Left(_player);
        _right = new Right(_player);
        _down = new Down(_player);
        _shoot = new Shoot(_player);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            _shoot.Execute();
        }
        if (!_player.HitDecoy())
        {
            if (Input.GetKey(KeyCode.W))
            {
                _up.Execute();
            }

            if (Input.GetKey(KeyCode.S))
            {
                _down.Execute();
            }

            if (Input.GetKey(KeyCode.A))
            {
                _left.Execute();
            }

            if (Input.GetKey(KeyCode.D))
            {
                _right.Execute();
            }
        }
        else if (_player.HitDecoy())
        {
            if (Input.GetKey(KeyCode.W))
            {
                _down.Execute();
            }

            if (Input.GetKey(KeyCode.S))
            {
                _up.Execute();
            }

            if (Input.GetKey(KeyCode.A))
            {
                _right.Execute();
            }

            if (Input.GetKey(KeyCode.D))
            {
                _left.Execute();
            }
        }
    }
}
