using UnityEngine;

namespace pikachu
{
    public class Monster: MonoBehaviour
    {
        #region ���ⳡ��
        [SerializeField, Header("�������")]
        private Rigidbody2D rBody;

        [SerializeField, Header("���ʳt��")]
        [Range(0, 10)]
        private float speed = 0.1f;

        [SerializeField, Header("�����O")]
        [Range(0,500)]
        private int attack = 100;

        [SerializeField, Header("��q")]
        [Range(0, 5000)]
        private int hp = 350;

        [SerializeField, Header("�l�ܽd��")]
        [Range(0, 50)] 
        private int tracking = 30;

        #endregion

        [SerializeField, Header("�D�㱼��")]
        private bool fall;
        [SerializeField]
        [Range(0, 1)]
        private float probability = 1;


    }
  

}