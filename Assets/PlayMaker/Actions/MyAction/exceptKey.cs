using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

[ActionCategory("myAction")]
public class exceptKey : FsmStateAction
{
        [RequiredField]
        [Tooltip("排除按了除中键以外的任何键")]
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
