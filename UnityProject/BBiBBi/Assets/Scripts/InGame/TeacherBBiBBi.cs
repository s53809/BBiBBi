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

            아 영어 쓰기 머리아프다 근데 생각해보니 이것들은 선생님 뿐만 아니라 다른 학생 관련도 관여해서
            선생님 모노비헤이비어보단 따로 게임을 진행하는 친구 하나를 만들어서 선생님이 산출한 결과를
            게임 진행하는 친구에게 넘겨주는 것이 좋을 듯

            그러면 게임 진행하는 친구가 선생님과 학생 객체를 가지고 있어야하고
            선생님과 학생에게 적재적소 원하는 정보를 요청하면 선생과 학생이 그 로직을 수행하는 방식으로
            진행하도록 하자
             */
        }
    }

}