using UnityEngine;
using UnityEngine.XR;

namespace pikachu
{
    public class Monster: MonoBehaviour
    {
        [SerializeField, Header("角色剛體")]
        private Rigidbody2D rBody;

        [SerializeField, Header("動畫控制器")]
        private Animator controller;

        [SerializeField, Header("移動速度")]
        [Range(0, 10)]
        private float speed = 0.1f;

        [SerializeField, Header("攻擊力")]
        [Range(0,500)]
        private int attack = 100;

        [SerializeField]
        private AudioSource[] attacktone;

        [SerializeField, Header("血量")]
        [Range(0, 5000)]
        private int hp = 350;

        [SerializeField, Header("受傷音效")]
        private AudioClip[] Injuried;

        [SerializeField, Header("追蹤範圍")]
        [Range(0, 50)] 
        private int tracking = 30;

        [SerializeField]

        private TrackingOriginModeFlags target;

        
        [SerializeField, Header("道具掉落")]
        private bool fall;

        [SerializeField, Header("道具掉落音效")]
        private AudioSource[] sound;

        [SerializeField]
        private GameObject[] weponprefbs;
        [SerializeField]
        [Range(0, 1)]
        private float probability = 1;
        
        
        
        
        
        

        

    }


}