using UnityEngine;

namespace pikachu
{
    public class Monster: MonoBehaviour
    {
        #region 紅色部分
        [SerializeField, Header("角色剛體")]
        private Rigidbody2D rBody;

        [SerializeField, Header("移動速度")]
        [Range(0, 10)]
        private float speed = 0.1f;

        [SerializeField, Header("攻擊力")]
        [Range(0,500)]
        private int attack = 100;

        [SerializeField, Header("血量")]
        [Range(0, 5000)]
        private int hp = 350;

        [SerializeField, Header("追蹤範圍")]
        [Range(0, 50)] 
        private int tracking = 30;

        #endregion

        [SerializeField, Header("道具掉落")]
        private bool fall;
        [SerializeField]
        [Range(0, 1)]
        private float probability = 1;


    }
  

}