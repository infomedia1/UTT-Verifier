using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace UTT_Verifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuartzPath_Click(object sender, EventArgs e)
        {
            dlgGetPath.Reset();
            dlgGetPath.ShowNewFolderButton = false;
            dlgGetPath.SelectedPath = "";
            if (dlgGetPath.ShowDialog() == DialogResult.OK)
            {
                edtQuartzPath.Text = dlgGetPath.SelectedPath;
            }       
        }

        private void btnVShapePath_Click(object sender, EventArgs e)
        {
            dlgGetPath.Reset();
            dlgGetPath.ShowNewFolderButton = false;
            dlgGetPath.SelectedPath = "";
            if (dlgGetPath.ShowDialog() == DialogResult.OK)
            {
                edtVShapePath.Text = dlgGetPath.SelectedPath;
            }
        }

        private void btnGetDates_Click(object sender, EventArgs e)
        {
            if ((edtQuartzPath.Text == "") || (edtVShapePath.Text == ""))
            {
                MessageBox.Show("Quartz or V-Shape Path not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string[] QuartzFiles = Directory.GetFileSystemEntries(edtQuartzPath.Text, "*.tif", SearchOption.TopDirectoryOnly);
            string[] VShapeFiles = Directory.GetFileSystemEntries(edtVShapePath.Text, "*.tif", SearchOption.TopDirectoryOnly);

            foreach (string QuartzFile in QuartzFiles)
            {
                FileInfo QuartzFileInfo = new FileInfo(QuartzFile);
                string QuartzDate = GetDate(QuartzFileInfo);
                lbQuartzDates.Items.Add(QuartzDate);
            }

            foreach (string VShapeFile in VShapeFiles)
            {
                FileInfo VShapeFileInfo = new FileInfo(VShapeFile);
                string VShapeDate = GetDate(VShapeFileInfo);
                lbVShapeDates.Items.Add(VShapeDate);
            }
        }

        // Source: https://stackoverflow.com/questions/2280948/reading-data-metadata-from-jpeg-xmp-or-exif-in-c-sharp
        public string GetDate(FileInfo f)
        {
            using (FileStream fs = new FileStream(f.FullName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                BitmapSource img = BitmapFrame.Create(fs);
                BitmapMetadata md = (BitmapMetadata)img.Metadata;
                string date = md.DateTaken;
                return date;
            }
        }
    }
}
