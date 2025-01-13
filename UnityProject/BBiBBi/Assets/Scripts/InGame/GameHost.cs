using System;
using UnityEngine;

public class GameHost : MonoSingleton<GameHost>
{
    public delegate void EventHandler();
    public delegate void EnterStageHandler(Int32 stageNum);

    [SerializeField] private Int32 _numberOfStage = 0; //임시 SerializeField
    private Int32 _stageNum = 0;

    //게임 흐름 제어용 이벤트
    public event EventHandler First_GameStart;
    public event EnterStageHandler Second_EnterStage;
    public event EventHandler Third_TeacherTurn;
    public event EventHandler Forth_PlayerTurn;
    public event EventHandler Fifth_CalculateScore;
    public event EventHandler Sixth_FinalScore;
    public event EventHandler Last_GameEnd;
    
    protected override void Awake()
    {
        base.Awake();
    }

    public void Start()
    {
        First_GameStart?.Invoke();
    }

    public void GoToStage(Int32 curStage)
    {
        switch (curStage)
        {
            case 2:
                Second_EnterStage?.Invoke(_stageNum);
                break;
            case 3:
                Third_TeacherTurn?.Invoke();
                break;
            case 4:
                Forth_PlayerTurn?.Invoke();
                break;
            case 5:
                Fifth_CalculateScore?.Invoke();
                break;
            case 6:
                Sixth_FinalScore?.Invoke();
                break;
            case 7:
                Last_GameEnd?.Invoke();
                break;
        }
    }
}
