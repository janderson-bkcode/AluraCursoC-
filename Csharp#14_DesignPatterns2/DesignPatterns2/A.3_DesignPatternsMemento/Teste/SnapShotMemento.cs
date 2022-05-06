using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._3_DesignPatternsMemento.Teste
    {/// <summary>
    /// Classe memento para armazenar o estado anterior do editor
    /// </summary>
    public class SnapShotMemento
    {
        public EditorOriginator Editor { get;  set; }

        public String Text { get; private set; }
        public String CurX { get; private set; }

        public String CurY { get; private set; }

        public String SelectionWidth { get; private set; }

        public SnapShotMemento(EditorOriginator editor,String text,String curX,String curY,String width)
        {
            this.Editor = editor;
            this.Text = text;
            this.CurX = curX;
            this.CurY = curY;
            this.SelectionWidth = width;
        }

        public SnapShotMemento()
        {
        }

        //Em algum momento , um estado anterior do editor poder ser
        //restaurado usando um objeto memento.
        public void Restore()
        {
            Editor.setText(this.Text);
            Editor.setCursor(CurX,CurY);
            Editor.setSelectionWidth(SelectionWidth);

        }

        public class Comand
        {
            public SnapShotMemento Backup { get; set; }

            public void MakeBackup()
            {
                Backup = new SnapShotMemento().Editor.createSnapShot();
            }

            public void undo()
            {
                if(Backup != null)
                {
                    Backup.Restore();
                }
            }

        }
    }
}
