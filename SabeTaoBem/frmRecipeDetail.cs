using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SabeTaoBemLibrary;
using System.Drawing.Drawing2D;
using System.Globalization;


namespace SabeTaoBem
{

    public partial class frmRecipeDetail : Form
    {

        //Fields
        static frmRecipeDetail _obj;

        //Property to get FormMain
        public static frmRecipeDetail Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new frmRecipeDetail();
                }
                return _obj;
            }
        }

        //Properties Definitons
        public ListView listViewIng
        {
            get { return listViewIngredients; }
            set { listViewIngredients = value; }
        }



        public frmRecipeDetail()
        {
            ////Instance of UserControlRecipes
            InitializeComponent();

        }


        // Form event
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //List view formatting
        SolidBrush myGreenBrush = new SolidBrush(Color.FromArgb(255, 116, 194,75));

        private void ListViewIngredients_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (var sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;

                using (var headerFont = new Font("Segoe Print", 11, FontStyle.Bold))
                {
                    e.Graphics.FillRectangle(myGreenBrush, e.Bounds);
                    e.Graphics.DrawString(e.Header.Text, headerFont, Brushes.White, e.Bounds, sf);
                }
            }
        }



        private void ListViewIngredients_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if ((e.State & ListViewItemStates.Selected) != 0)
            {
                // Draw the background and focus rectangle for a selected item.
                e.Graphics.FillRectangle(myGreenBrush, e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private void ListViewIngredients_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {

            if ((e.ItemState & ListViewItemStates.Focused) != 0)
            {
                e.Graphics.FillRectangle(myGreenBrush, e.Bounds);
                e.Graphics.DrawString(e.SubItem.Text, listViewIng.Font, SystemBrushes.HighlightText, e.Bounds);
            }
            else
            {
                e.DrawBackground();
                e.DrawText();
            }
        }

       
    }
}
