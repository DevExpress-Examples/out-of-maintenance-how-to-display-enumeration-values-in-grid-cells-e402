using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;

namespace WindowsApplication274
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindingList<Record> list = new BindingList<Record>();
            list.Add(new Record(temp.valuefor1 ));
            list.Add(new Record(temp.valuefor2 ));

            RepositoryItemImageComboBox item = new RepositoryItemImageComboBox();
            item.Items.AddEnum(typeof(temp));
            gridControl1.RepositoryItems.Add(item);
            gridControl1.DataSource = list;
            gridView1.PopulateColumns();
            gridView1.Columns["EnumValue"].ColumnEdit = item;
            gridView1.Columns["EnumValue"].OptionsColumn.ReadOnly = true;
            gridView1.Columns["EnumValue"].OptionsColumn.AllowEdit = false;
        }
    }
   
    public  enum temp
    {
        valuefor1 = 1,
        valuefor2 = 2
    }
    class Record {
        public Record(temp eVal) { _enumValue = eVal; }
        temp _enumValue;
        public temp EnumValue { get { return _enumValue; } }
    }
}