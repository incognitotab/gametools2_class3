using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour {
    private Animator m_animator;
    
	// Use this for initialization
	void Start () {
        m_animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	

    public void Move(float turn, float forward)
    {
        m_animator.SetFloat("turn", turn);
        m_animator.SetFloat("Forward", forward);
    }
}
