using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace InternshipsManageApp
{
    public class BaseForm : Form
    {
        private Dictionary<Control, Rectangle> originalSizes = new Dictionary<Control, Rectangle>();
        private Size originalFormSize;

        public BaseForm()
        {
            this.Load += BaseForm_Load;
            this.Resize += BaseForm_Resize;
        }

        private void BaseForm_Load(object sender, System.EventArgs e)
        {
            originalFormSize = this.Size;
            SaveControlSizes(this);
        }

        private void BaseForm_Resize(object sender, System.EventArgs e)
        {
            AdjustControlSizes(this);
        }

        // Lưu kích thước và vị trí ban đầu của các control
        protected void SaveControlSizes(Control container)
        {
            foreach (Control control in container.Controls)
            {
                originalSizes[control] = new Rectangle(control.Location, control.Size);
                if (control.HasChildren)
                {
                    SaveControlSizes(control);
                }
            }
        }

        // Điều chỉnh kích thước và vị trí của các control
        protected void AdjustControlSizes(Control container)
        {
            float xRatio = (float)this.Width / originalFormSize.Width;
            float yRatio = (float)this.Height / originalFormSize.Height;

            foreach (Control control in container.Controls)
            {
                if (originalSizes.ContainsKey(control))
                {
                    Rectangle original = originalSizes[control];
                    control.Location = new Point(
                        (int)(original.X * xRatio),
                        (int)(original.Y * yRatio)
                    );
                    control.Size = new Size(
                        (int)(original.Width * xRatio),
                        (int)(original.Height * yRatio)
                    );
                }

                if (control.HasChildren)
                {
                    AdjustControlSizes(control);
                }
            }
        }
    }
}

