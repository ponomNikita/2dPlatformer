using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
	public class BaseController
	{
        private Animator _animatior;

        private Rigidbody2D _hero;

        private Transform _transform;

        private bool isFaceRight;


        public BaseController (Transform transform, Rigidbody2D hero, Animator animatior)
		{
			_hero = hero;
            _animatior = animatior;
            isFaceRight = true;
            _transform = transform;
        }

		public void Move(float horizontal, float speed)
		{
            _animatior.SetFloat("speed", Mathf.Abs(horizontal));
            _hero.velocity = new Vector2(horizontal * speed, _hero.velocity.y);
            Flip(horizontal);
        }

        private void Flip(float horizontal)
        {
            if (isFaceRight && horizontal < 0 || !isFaceRight && horizontal > 0)
            {
                isFaceRight = !isFaceRight;
                Vector2 scale = _transform.localScale;
                scale.x *= -1;
                _transform.localScale = scale;
            }
        }
    }
}

