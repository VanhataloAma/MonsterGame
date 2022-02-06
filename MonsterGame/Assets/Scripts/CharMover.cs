using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GA.MonsterGame
{
    public class CharMover : MonoBehaviour
    {
        private CharacterController m_ccCharacterController;
        private Vector3 m_vDirection;

        public float m_fMoveSpeed;
        // Start is called before the first frame update
        void Start()
        {
            m_ccCharacterController = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void Update()
        {
            m_vDirection.x = Input.GetAxis("Horizontal");
            m_vDirection.z = Input.GetAxis("Vertical");
            m_vDirection.Normalize();

            m_ccCharacterController.Move(m_fMoveSpeed * m_vDirection * Time.deltaTime);
        }
    }
}
