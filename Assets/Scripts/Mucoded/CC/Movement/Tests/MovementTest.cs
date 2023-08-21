using Mucoded.CC.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mucoded.CC.Movement.Tests
{
    [RequireComponent(typeof(CharacterController))]
    public class MovementTest : MonoBehaviour
    {
        private Vector3 _movementInput;
        [SerializeField]
        public Vector2 MovementInput
        {
            get
            {
                return _movementInput;

            }
            set
            {
                _movementInput.x = value.x;
                _movementInput.z = value.y;
                _movementInput.y = 0;
            }
        }
        private float _movementSpeed = 4f;

        private CharacterController _characterController;
        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
        }
        private void Update()
        {
            _characterController.SimpleMove(_movementInput * _movementSpeed);
       
        }

    }
}

