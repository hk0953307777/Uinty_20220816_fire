using UnityEngine;
using UnityEngine.XR;

namespace pikachu
{
    public class Monster: MonoBehaviour
    {
        [SerializeField, Header("�������")]
        private Rigidbody2D rBody;

        [SerializeField, Header("�ʵe���")]
        private Animator controller;

        [SerializeField, Header("���ʳt��")]
        [Range(0, 10)]
        private float speed = 0.1f;

        [SerializeField, Header("�����O")]
        [Range(0,500)]
        private int attack = 100;

        [SerializeField]
        private AudioSource[] attacktone;

        [SerializeField, Header("��q")]
        [Range(0, 5000)]
        private int hp = 350;

        [SerializeField, Header("���˭���")]
        private AudioClip[] Injuried;

        [SerializeField, Header("�l�ܽd��")]
        [Range(0, 50)] 
        private int tracking = 30;

        [SerializeField]

        private TrackingOriginModeFlags target;

        
        [SerializeField, Header("�D�㱼��")]
        private bool fall;

        [SerializeField, Header("�D�㱼������")]
        private AudioSource[] sound;

        [SerializeField]
        private GameObject[] weponprefbs;
        [SerializeField]
        [Range(0, 1)]
        private float probability = 1;
        
        
        
        
        
        

        

    }


}