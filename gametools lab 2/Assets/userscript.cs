using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userscript : MonoBehaviour {

    private float m_turn;
    private float m_forward;

    private character m_character;

    private void FixedUpdate()
    {
        m_turn = Input.GetAxis("Horizontal");
        m_forward = Input.GetAxis("Vertical");
        m_character.Move(m_turn, m_forward);
    }
}
