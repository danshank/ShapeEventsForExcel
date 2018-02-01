using System;

namespace ShapeEventsForExcel
{
    public class ShapeListener
    {
        public event EventHandler<string> ShapeClick;

        public void Click(string shapeName)
        {
            OnShapeClick(shapeName);
        }

        protected virtual void OnShapeClick(string shapeName)
        {
            ShapeClick?.Invoke(this, shapeName);
        }
    }
}
