using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenNETCF.Desktop.Communication;

namespace LiveEvent_Sync
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            RAPI device = new RAPI();
            device.Connect();
            IEnumerable<FileInformation> lol = device.EnumerateFiles(@"\Application Data\SU_MT2000_SUIDScanner\admit-lists\*");
            foreach (FileInformation i in lol) {
                Console.WriteLine(i.FileName);
            }
        }
    }
}
