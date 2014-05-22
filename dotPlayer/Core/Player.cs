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
        public string LoadFile()
        {
                OpenFileDialog ofdSearchFile = new OpenFileDialog();

                ofdSearchFile.Title = "Select media";
                ofdSearchFile.Filter = "All Suported|* .wmv;* .avi;* .mp3";
                ofdSearchFile.FilterIndex = 1;

                if (ofdSearchFile.ShowDialog() == true)
                {
                    return ofdSearchFile.FileName; 
                }

                return "";
        }
    }
}
