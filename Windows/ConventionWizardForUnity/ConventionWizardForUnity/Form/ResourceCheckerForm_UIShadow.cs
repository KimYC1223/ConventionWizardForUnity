namespace ConventionWizardForUnity
{
#pragma warning disable CA1806

    ///==========================================================================================================================
    ///
    ///  Initializing Form
    ///  ------------------------------------------------------------------------------------------------------------------------
    ///  Initializing Form에 Shadow 효과를 주는 메서드
    ///
    ///==========================================================================================================================
    public partial class InitializingForm
    {
        ///======================================================================================================================
        ///  PROTECED 멤버 변수
        ///======================================================================================================================
        protected override CreateParams CreateParams
        {
            get
            {
                aeroEnabled = CheckAeroEnabled();
                var cp = base.CreateParams;
                if (aeroEnabled == false)
                {
                    cp.ClassStyle |= CS_DROPSHADOW;
                }
                return cp;
            }
        }

        ///======================================================================================================================
        ///  PRIVATE 멤버 변수
        ///======================================================================================================================
        private const int CS_DROPSHADOW = 0x00020000;

        private const int WM_NCPAINT = 0x0085;
        private bool aeroEnabled;

        ///======================================================================================================================
        ///  STRUCT 정의
        ///======================================================================================================================
        private struct MARGINS
        {
            public int LeftWidth;
            public int RightWidth;
            public int TopHeight;
            public int BottomHeight;
        }

        ///======================================================================================================================
        ///  PROTECED 메서드
        ///======================================================================================================================
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
            case WM_NCPAINT:
            if (aeroEnabled)
            {
                var v = 2;
                DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                var margins = new MARGINS()
                {
                    BottomHeight = 1,
                    LeftWidth = 0,
                    RightWidth = 0,
                    TopHeight = 0
                }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
            }
            break;

            default: break;
            }
            base.WndProc(ref m);
        }

        ///======================================================================================================================
        ///  PRIVATE EXTERN 메서드
        ///======================================================================================================================
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        private static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        private static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        ///======================================================================================================================
        ///  PRIVATE 메서드
        ///======================================================================================================================
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1);
            }
            return false;
        }
    }

#pragma warning restore CA1806
}