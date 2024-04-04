using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship2024.Model;
using Internship2024.Presenter;
using Internship2024.Service;
using Internship2024.View;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;

namespace Internship2024
{
    public partial class AddItems : Form, IAreaCreateView
    {
        private  Internship2024DB db;
         pl_areaRow _areaRow = new pl_areaRow();
        public AddItems()
        {
            InitializeComponent();
            
            Internship2024DB db = new Internship2024DB(); 
            AreaCreateRepository repository = new AreaCreateRepository(db); 
            AreaCreateService service = new AreaCreateService(repository); 
            Presenter = new AreaCreatePresenter(this, service); 
            
            
            
        }

        private void ultraLabel1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close the window? :(", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                
            }
            else
            {
                // this will handle "Cancel" button click
            }
        }

        private void ultraCheckEditor1_CheckedChanged(object sender, EventArgs e)
        {

        }
        

        public string UniqueCode
        {
            get { return uniqueCodeTxt.Text; }
            set { uniqueCodeTxt.Text = value; }
        }
        
        
        
        public string AreaName 
        {  get { return areaNameTxt.Text;}
            set { areaNameTxt.Text = value;}
            
        }
        public string AreaCode
        { 
            get { return areaCodeTxt.Text;}
            set { areaCodeTxt.Text = value;} 
        }
        public string Description 
        {  
            get { return desTextArea.Text;}
            set { desTextArea.Text = value;} 
        }
        //
        // public  DepartmentName
        // {
        //     get { return Convert.ToInt32(departmentNameTxt.Text);}
        //     set { departmentNameTxt.Text = value.ToString(); }
        // }

        // public int DepartmentID
        // {
        //     get { return departmentNameTxt.SelectedValue.Text;}
        //     set { departmentNameTxt.Text = value; }
        // }

        public bool IsActive
        {
            get { return isActiveCheckbox.Checked;}
            set { isActiveCheckbox.Checked = value;}
        }
        public bool IsForDispensing 
        { 
            get { return isforDispenCheckBox.Checked;}
            set { isforDispenCheckBox.Checked = value;}
            
        }
        public AreaCreatePresenter Presenter { get; set; }
        
        public void DisplayDepartments(List<Department> departments)
        {
            departmentNameTxt.DataSource = departments;
            departmentNameTxt.DisplayMember = "Name";
            departmentNameTxt.ValueMember = "ID";
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int departmentId = Convert.ToInt32(departmentNameTxt.SelectedValue);
                
                _areaRow.Unique_code = UniqueCode;
                _areaRow.Area_code = AreaCode;
                _areaRow.Name = AreaName;
                _areaRow.Description = Description;
                _areaRow.Department_id = departmentId;
                _areaRow.Is_for_dispensing = IsForDispensing;
                _areaRow.Status = IsActive;
                // _areaRow.Table_pid = 1;
                Presenter.CreateArea(_areaRow);
                MessageBox.Show("The data is inserted sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.Message);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void isforDispenCheckBox_Click(object sender, EventArgs e)
        {
            
        }

// //private void AddItems_Load(object sender, EventArgs e)
//         {
//             throw new System.NotImplementedException();
//         }
    }
}
