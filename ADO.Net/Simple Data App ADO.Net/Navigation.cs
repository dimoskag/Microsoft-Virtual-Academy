using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDataApp
{
   public partial class Navigation : Form
   {
      public Navigation()
      {
         InitializeComponent();
      }

      //Open the NewCustomer form as a dialog box, which will return focus to the calling form when it closes.
      private void btnGoToAdd_Click(object sender, EventArgs e)
      {
         Form frm = new NewCustomer();
         frm.Show();
      }

      //Open the FillorCancel form as a dialog box.
      private void btnGoToFillOrCancel_Click(object sender, EventArgs e)
      {
         Form frm = new FillOrCancel();
         frm.ShowDialog();
      }

      //Close the appplication not just the Navigation form.
      private void btnExit_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
