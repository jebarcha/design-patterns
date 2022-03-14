using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class Canvas
    {
        private ITool _currentTool;
        public ITool GetCurrentTool()
        {
            return _currentTool;
        }

        public void SetCurrentTool(ITool currentTool)
        {
            _currentTool = currentTool;
        }

        public void MouseDown()
        {
            _currentTool.MouseDown();
        }
        public void MouseUp()
        {
            _currentTool.MouseUp();
        }

        //private ToolType currentTool;

        //public ToolType CurrentTool { get => currentTool; set => currentTool = value; }

        //public void MouseDown() 
        //{
        //    if (currentTool == ToolType.SELECTION)
        //    {
        //        Console.WriteLine("Selection icon");
        //    } 
        //    else if (currentTool == ToolType.BRUSH)
        //    {
        //        Console.WriteLine("Brush icon");
        //    } 
        //    else if (CurrentTool == ToolType.ERASER)
        //    {
        //        Console.WriteLine("Eraser icon");
        //    }
        //}
        //public void MouseUp() 
        //{
        //    if (currentTool == ToolType.SELECTION)
        //    {
        //        Console.WriteLine("Draw dashed rectangle");
        //    }
        //    else if (currentTool == ToolType.BRUSH)
        //    {
        //        Console.WriteLine("Draw a line");
        //    }
        //    else if (CurrentTool == ToolType.ERASER)
        //    {
        //        Console.WriteLine("Erase something");
        //    }
        //}
    }
}
