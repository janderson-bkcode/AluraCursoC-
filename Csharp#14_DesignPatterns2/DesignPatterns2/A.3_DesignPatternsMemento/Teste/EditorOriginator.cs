using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._3_DesignPatternsMemento.Teste
{
    public class EditorOriginator
    {
        public String Text { get; private set; }
        public String CurX { get; private set; }

        public String CurY { get; private set; }

        public String SelectionWidth { get; private set; }


        public void setText(String text)
        {
            this.Text = text;
        }

        public void setCursor(String x,String y)
        {
            this.CurX = x;
            this.CurY = y;
        }

        public void setSelectionWidth(String width)
        {
            this.SelectionWidth = width;
        }

        //Salva o estado atual dentro de um  Memento

        public SnapShotMemento createSnapShot()
        {
            return new SnapShotMemento(this, Text, CurX, CurY, SelectionWidth);
        }

    }
}
