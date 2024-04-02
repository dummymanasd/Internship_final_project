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

namespace Internship2024
{
    public partial class AddItems : Form, IAreaCreateView
    {
        private  Internship2024DB db;
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

        public string DepartmentName
        {
            get { return departmentNameTxt.Text;}
            set { departmentNameTxt.Text = value;}
        }

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
        
       


        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Presenter.CreateArea();
                MessageBox.Show("The data is inserted sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }
        
    }
}
