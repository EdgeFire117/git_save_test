using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using Random = UnityEngine.Random;
using UnityEngine.UI;

#pragma warning disable 618, 649

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(AudioSource))]
public class FirstPersonController : MonoBehaviour
{
    [SerializeField] private bool m_IsWalking;
    [SerializeField] private float m_WalkSpeed;
    [SerializeField] private float m_RunSpeed;
    [SerializeField] [Range(0f, 1f)] private float m_RunstepLenghten;
    [SerializeField] private float m_JumpSpeed;
    [SerializeField] private float m_StickToGroundForce;
    [SerializeField] private float m_GravityMultiplier;
    [SerializeField] private MouseLook m_MouseLook;
    [SerializeField] private bool m_UseFovKick;
    [SerializeField] private FOVKick m_FovKick = new FOVKick();
    [SerializeField] private bool m_UseHeadBob;
    [SerializeField] private CurveControlledBob m_HeadBob = new CurveControlledBob();
    [SerializeField] private LerpControlledBob m_JumpBob = new LerpControlledBob();
    [SerializeField] private float m_StepInterval;
    [SerializeField] private AudioClip[] m_FootstepSounds;    // an array of footstep sounds that will be randomly selected from.
    [SerializeField] private AudioClip m_JumpSound;           // the sound played when character leaves the ground.
    [SerializeField] private AudioClip m_LandSound;

    float timer;
    float vs;
    float rex;
    float dev;
    float fox;

    void Awake()
    {
        string String_Awake = GameObject.Find("Canvas").GetComponent<Text>().text = "717";
        float float_Awake = 914;
        vs = 10;
        dev = 20;
    }

    void Start()
    {
        float start = 515;
        start = 721;
    }

    void Update
    {
        timer += Time.DeltaTime;
        if(timer > 10)
        {
        timer = 0;
        timer = 10;
        dev = 47
}
    }

}