using System.Collections.Generic;
using System;
using UnityEngine;

namespace ForTeacherBBiBBi
{
    public class TeacherBBiBBi : MonoBehaviour
    {
        private CommanderForTeacher _magicalWand;
        private List<CommandEnum> _curCommands = null;
        private void Awake()
        {
            _magicalWand = new CommanderForTeacher();
        }

        public void StartOrderLogic(Int32 howManyOrder)
        {
            _magicalWand.AMagicCommandMixingMachineForStudents(howManyOrder);
            _curCommands = _magicalWand.GetTheFinalCommandInstruction();

            /* #todo list
            1. send this commmand to player
            2. must be displayed as UI
            
            3. must be displayed to the song
            4. so you have to choose the right music on your own

            �� ���� ���� �Ӹ������� �ٵ� �����غ��� �̰͵��� ������ �Ӹ� �ƴ϶� �ٸ� �л� ���õ� �����ؼ�
            ������ �������̺��� ���� ������ �����ϴ� ģ�� �ϳ��� ���� �������� ������ �����
            ���� �����ϴ� ģ������ �Ѱ��ִ� ���� ���� ��

            �׷��� ���� �����ϴ� ģ���� �����԰� �л� ��ü�� ������ �־���ϰ�
            �����԰� �л����� �������� ���ϴ� ������ ��û�ϸ� ������ �л��� �� ������ �����ϴ� �������
            �����ϵ��� ����
             */
        }
    }

}