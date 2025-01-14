using System.Collections.Generic;
using System;
using UnityEngine;

namespace ForTeacherBBiBBi
{
    public class TeacherBBiBBi : MonoBehaviour
    {
        private CommanderForTeacher _magicalWand;
        private List<CommandEnum> _curCommands = null;

        [SerializeField] private ObjectPool _arrowPooler;

        [SerializeField] private Sprite _arrowUpSprite;
        [SerializeField] private Sprite _arrowDownSprite;
        [SerializeField] private Sprite _arrowLeftSprite;
        [SerializeField] private Sprite _arrowRightSprite;

        [SerializeField] private Int32 _arrowRow;
        [SerializeField] private Int32 _arrowColumn;
        private void Awake()
        {
            _magicalWand = new CommanderForTeacher();
            GameHost.Ins.Third_TeacherTurn += GameStart;
        }
        public void GameStart() 
        {
            StartOrderLogic(14);
        }

        public void StartOrderLogic(Int32 howManyOrder)
        {
            _magicalWand.AMagicCommandMixingMachineForStudents(howManyOrder);
            _curCommands = _magicalWand.GetTheFinalCommandInstruction();
            ShowArrow();

            /* #todo list          
            2. must be displayed to the song
            3. so you have to choose the right music on your own

            �� ���� ���� �Ӹ������� �ٵ� �����غ��� �̰͵��� ������ �Ӹ� �ƴ϶� �ٸ� �л� ���õ� �����ؼ�
            ������ �������̺��� ���� ������ �����ϴ� ģ�� �ϳ��� ���� �������� ������ �����
            ���� �����ϴ� ģ������ �Ѱ��ִ� ���� ���� ��

            �׷��� ���� �����ϴ� ģ���� �����԰� �л� ��ü�� ������ �־���ϰ�
            �����԰� �л����� �������� ���ϴ� ������ ��û�ϸ� ������ �л��� �� ������ �����ϴ� �������
            �����ϵ��� ����
             */
        }

        private void ShowArrow()
        {
            Int32 index = 0;
            foreach(var command in _curCommands)
            {
                GameObject obj = _arrowPooler.SpawnObject("BlackBoard_Arrow");
                SpriteRenderer sr = obj.GetComponent<SpriteRenderer>();

                if (command == CommandEnum.Up) sr.sprite = _arrowUpSprite;
                if (command == CommandEnum.Down) sr.sprite = _arrowDownSprite;
                if (command == CommandEnum.Right) sr.sprite = _arrowRightSprite;
                if (command == CommandEnum.Left) sr.sprite = _arrowLeftSprite;

                obj.transform.localPosition = new Vector3(
                    -0.9f + (0.1f * (index % _arrowColumn)), 
                    0.26f - (0.1f * (index / _arrowColumn)), 
                    0);

                index++;
            }
        }
    }

}