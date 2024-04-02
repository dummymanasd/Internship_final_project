using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internship2024
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Internship2024DB objTran = null;
        private void frmMain_Load(object sender, EventArgs e)
        {
            objTran = new Internship2024DB();
            if(objTran != null )
            {
                MessageBox.Show($"Connected to: {objTran.Connection.Database}");
            }

            try
            {

                pl_object objpl_object = new pl_object(objTran);
                pl_objectRow objpl_objectRow = objpl_object.GetRow("name = 'test_name2'");

                pl_string objpl_string = new pl_string(objTran);
                pl_stringRow objpl_stringRow = null;

                objTran.BeginTransaction(); 
                if (objpl_objectRow != null)
                {
                    MessageBox.Show(objpl_objectRow.Table_name);
                }
                else
                {
                    objpl_objectRow = new pl_objectRow();
                    objpl_objectRow.Table_name = "test_table";
                    objpl_objectRow.Name = "test_name2";
                    objpl_objectRow.Created_date = DateTime.Now;
                    objpl_objectRow.Created_by = 1;
                    var table_pid = objpl_object.Insert(objpl_objectRow);
                    MessageBox.Show($"{objpl_objectRow.Name} has been added successfully");

                    objpl_stringRow = new pl_stringRow();
                    objpl_stringRow.Table_pid = table_pid;
                    objpl_stringRow.Column_type ="test_column_type";
                    objpl_stringRow.Data_value = "test_data_value";
                    objpl_string.Insert(objpl_stringRow);
                }
                objTran.CommitTransaction();
            }
            catch (Exception)
            {

                objTran.RollbackTransaction();
            }
            finally
            {
                objTran.Dispose();
            }
            
            



        }
    }
}
