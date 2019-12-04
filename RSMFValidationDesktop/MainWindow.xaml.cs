using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.IO;
using Microsoft.Win32;

using RSMFValidationSampleCode;


namespace RSMFValidationDesktop.Dialogs
{
    public partial class OpenFileDialogSample : Window
    {
        public OpenFileDialogSample()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string[] directoryPath = new String[1] { openFileDialog.FileName.Replace($"\\{openFileDialog.SafeFileName}", "") };
                SampleProgram.Main(directoryPath);
                string logLocation = System.Reflection.Assembly.GetEntryAssembly().Location;
                logLocation = logLocation.Replace("RSMFValidationDesktop.dll", newValue: "rsmf.validation.log.txt");
                //txtEditor.Text = logLocation;
                //txtEditor.Text = directoryPath;
                txtEditor.Text = File.ReadAllText(logLocation);
            }
        }
    }
}