using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace ConventionWizardForUnity
{
    //1. 프로젝트 내의 Resources폴더(임의로 생성한 폴더)에 폰트파일(ttf) 복사
    //2. Resources.resx 에 복사한 ttf파일을 리소스 추가
    internal class FontManager
    {
        private static FontManager instance = new FontManager();
        public PrivateFontCollection PrivateFont = new PrivateFontCollection();

        public static FontFamily[] FontFamilys => instance.PrivateFont.Families;

        public FontManager()
        {
            AddFontFromMemory();
        }

        private void AddFontFromMemory()
        {
            var fonts = new List<byte[]>
            {
                Properties.Resources.D2Coding
            };

            foreach (byte[] font in fonts)
            {
                var fontBuffer = Marshal.AllocCoTaskMem(font.Length);
                Marshal.Copy(font, 0, fontBuffer, font.Length);
                PrivateFont.AddMemoryFont(fontBuffer, font.Length);

                Marshal.FreeHGlobal(fontBuffer);//메모리 해제
            }
        }
    }
}