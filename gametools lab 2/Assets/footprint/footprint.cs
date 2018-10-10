using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footprint : MonoBehaviour {
    private Animator m_animator;
    private Transform m_rightfoottransform;
    private Transform m_leftfoottransform;

    private void Start()
    {
        m_animator = GetComponent<Animator>();

        m_rightfoottransform = m_animator.GetBoneTransform(HumanBodyBones.RightFoot);
        m_leftfoottransform = m_animator.GetBoneTransform(HumanBodyBones.LeftFoot);
    }

    public void MakeFootPrint()
    {
        Debug.Log("footprint");
        if (scale > 0)
        {
            Instantiate(m_footprint, m_leftfoottransform.position, m_leftfoottransform.rotation);
        }

    }
}
