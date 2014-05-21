using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotPlayer.Core
{
    public class Player
    {
        public Uri LoadFile()
        {

                OpenFileDialog ofdSearchFile = new OpenFileDialog();

                ofdSearchFile.ShowDialog();

                ofdSearchFile.Filter = "All Files (*.*)|*.*";
                ofdSearchFile.FilterIndex = 1;
                Uri uri = new Uri(ofdSearchFile.FileName);
                

                return uri;

        }
    }
}
