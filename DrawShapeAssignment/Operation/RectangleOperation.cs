using System;
using Entities;
using DrawShape;

namespace Operation
{
    public class RectangleOperation : IRectangleOperation
    {
        public void DrawingRectangle(Rectangle rectangle)
        {
            System.Windows.Forms.Application.Run(new FormForRectangle(rectangle));
            //throw new NotImplementedException();
        }
    }
}