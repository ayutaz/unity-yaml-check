using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Test
{
    public class Button : UIBehaviour,IPointerClickHandler
    {
        public UnityEvent onClick;

        public void OnPointerClick(PointerEventData eventData)
        {
            onClick?.Invoke();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            onClick.RemoveAllListeners();
        }
    }
}