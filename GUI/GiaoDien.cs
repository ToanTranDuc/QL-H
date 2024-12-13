using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
   
    public partial class GiaoDien : Form
    { 
        
        bool sidebarExpand;
        bool qlspCollapse;
        bool qlnccCollapse;
        public GiaoDien()
        {
            InitializeComponent();
        }

        

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarControl.Width -= 10;
                if (sidebarControl.Width == sidebarControl.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timerSidebar.Stop();
                }
            }
            else 
            {
                sidebarControl.Width += 10;
                if (sidebarControl.Width == sidebarControl.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timerSidebar.Stop();
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        private void btnGDQLSP_Click_1(object sender, EventArgs e)
        {
            qlspCollapse = !qlspCollapse; 
            QLSPTimer.Stop();
            QLSPTimer.Start();
        }

        private void QLSPTimer_Tick_1(object sender, EventArgs e)
        {
            if (qlspCollapse)
            {
                QLSPContainer.Height -= 10; // Đóng container
                if (QLSPContainer.Height <= QLSPContainer.MinimumSize.Height)
                {
                    qlspCollapse = true; // Đã đóng xong
                    QLSPTimer.Stop();
                }
            }
            else
            {
                QLSPContainer.Height += 10; // Mở container
                if (QLSPContainer.Height >= QLSPContainer.MaximumSize.Height)
                {
                    qlspCollapse = false; // Đã mở xong
                    QLSPTimer.Stop();
                }
            }
        }

        private void QLNCCTimer_Tick(object sender, EventArgs e)
        {
            if (qlnccCollapse)
            {
                QLNCCContainer.Height -= 10; // Đóng container
                if (QLNCCContainer.Height <= QLNCCContainer.MinimumSize.Height)
                {
                    qlnccCollapse = true; 
                    QLNCCTimer.Stop();
                }
            }
            else
            {
                QLNCCContainer.Height += 10; 
                if (QLNCCContainer.Height >= QLNCCContainer.MaximumSize.Height)
                {
                    qlnccCollapse = false; 
                    QLNCCTimer.Stop();
                }
            }
        }
        private void btnGDQLNCC_Click(object sender, EventArgs e)
        {
            
            qlnccCollapse = !qlnccCollapse;

            QLNCCTimer.Stop();
            QLNCCTimer.Start(); 
        }


        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();

            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnGDSanPham_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new DSSanPham());
        }

        private void btnGĐanhMucSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DanhMucSP());
        }

        private void btnDGThongTinNCC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InforNCC());
        }

        private void btnDGHopDong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Contract());
        }


    }
}
