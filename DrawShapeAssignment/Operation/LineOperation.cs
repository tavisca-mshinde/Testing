using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entities;
using DrawShape;

namespace Operation
{
  public class LineOperation: ILineOperation
    {
       public void DrawingLine(Line line)
        {
            Application.Run(new FormLine(line));
        }
    }
}
