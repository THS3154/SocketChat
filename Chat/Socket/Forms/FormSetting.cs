using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Socket.Forms
{
    class FormSetting
    {
        //폼 기본 셋팅
        public FormBorderStyle MyFormBorderStyle()
        {
            return FormBorderStyle.FixedToolWindow;
        }

        
        public Color MyFormColor()
        {
            //폼 색상
            return Color.FromArgb(47, 49, 54);
        }
        
        public Color MyFontColor()
        {
            //텍스트 컬러 #ffffff
            return Color.FromArgb(255, 255, 255);
        }
    }
}
