using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZ_RFID_Simulator
{
    public partial class EZPOSForm : Form
    {
        private Model _model;

        public EZPOSForm()
        {
            InitializeComponent();
            _model = new Model();
        }
        
        private void EZPOSForm_Load(object sender, EventArgs e)
        {
            List<string> list = _model.IdList;
            list.ForEach(id => AddButton(id));
            _itemDataGridView.DataSource = _model.OrderList;
            _portComboBox.DataSource = _model.Ports;
            HandleControl(true);
        }

        private void HandleControl(bool value)
        {
            _openPortButton.Enabled = value;
            _sendButton.Enabled = !value;
            _portComboBox.Enabled = value;
        }

        private void AddButton(String id)
        {
            Button button = new Button()
            {
                Dock = DockStyle.Fill,
                Text = id,                              
            };
            button.Click += ClickIdButton;
            _itemTableLayoutPanel.Controls.Add(button);
        }

        private void ClickIdButton(object sender, EventArgs e)
        {
            string id = ((Button)sender).Text;
            _model.PickId(id);
        }

        private void _clearButton_Click(object sender, EventArgs e)
        {
            _model.Clear();
        }

        private void _openPortButton_Click(object sender, EventArgs e)
        {
            string portName = _portComboBox.Text;
            _model.OpenPort(portName);
            HandleControl(false);
        }

        private void _sendButton_Click(object sender, EventArgs e)
        {
            _model.Send();
        }
    }
}