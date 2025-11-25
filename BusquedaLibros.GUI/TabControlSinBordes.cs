using System;
using System.Windows.Forms;

public class TabControlSinBordes : TabControl
{
    // Interceptamos los mensajes de Windows
    protected override void WndProc(ref Message m)
    {
        // 0x1328 = TCM_ADJUSTRECT (Calcula el área blanca donde van los controles)
        if (m.Msg == 0x1328 && !DesignMode)
        {
            // Le decimos a Windows que el contenido debe ocupar TODO el control
            m.Result = (IntPtr)1;
            return; // ¡Importante! No dejamos que el control base haga su cálculo
        }

        // 0x85 = WM_NCPAINT (Pinta el borde "no cliente" o marco)
        if (m.Msg == 0x85 && !DesignMode)
        {
            // Al interceptar esto y no llamar a base, evitamos que Windows dibuje el marco.
            return;
        }

        base.WndProc(ref m);
    }
}