using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class PlayerController : MonoBehaviour
    {
        private BaseController _baseController;

        private Animator _animatior;

        private Rigidbody2D _player;

        [SerializeField]
        private float _speed;

        void Start()
        {
            _player = GetComponent<Rigidbody2D>();
            _animatior = GetComponent<Animator>();
            _baseController = new BaseController(transform, _player, _animatior);
        }

        void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            _baseController.Move(horizontal, _speed);
        }
    }
}
