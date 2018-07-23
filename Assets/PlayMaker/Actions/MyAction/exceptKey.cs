using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

[ActionCategory("myAction")]
public class exceptKey : FsmStateAction
{
        [RequiredField]
        [Tooltip("�ų����˳��м�������κμ�")]
        public FsmEvent anyKeySentEvent;
        public FsmEvent exceptKeySentEvent;

        public KeyCode expectKey;

        public override void Reset()
        {
            anyKeySentEvent = null;
            exceptKeySentEvent = null;
            expectKey = KeyCode.None;
        }

        public override void OnUpdate()
        {
            if(Input.anyKeyDown)
            {
                bool keyDown = Input.GetKeyDown(expectKey);

                if (keyDown)
                    Fsm.Event(exceptKeySentEvent);
                else
                    Fsm.Event(anyKeySentEvent);
            }
        }

    }

}
