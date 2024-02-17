﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TourTest.Context.DB;
using TourTest.Context.Models;
using Type = TourTest.Context.Models.Type;

namespace TourTest.Window.Forms
{
    public partial class TourInfoForm : Form
    {
        private readonly Tour tour;
        public TourInfoForm()
        {
            InitializeComponent();
            Text = "Добавление тура";
            butAdd.Text = "Добавить";
            butDelete.Visible= false;
            checkedListBox.DisplayMember = nameof(Type.Name);
            comboBoxCountry.DisplayMember = nameof(Country.Name);
            this.tour = new Tour();
            
            using (var db =new TourContext())
            {
                comboBoxCountry.Items.AddRange(db.Countries.AsNoTracking().ToArray());
                comboBoxCountry.SelectedIndex = 0;
                checkedListBox.Items.AddRange(db.Types.AsNoTracking().ToArray());
            }
        }

        public TourInfoForm(Tour tour) : this()
        {
            Text = "Изменения тура";
            butAdd.Text = "Изменить";
            this.tour = tour;
            butDelete.Visible = true;
            textBoxName.Text = tour.Name;
            textBoxPrice.Text = tour.Price.ToString();
            checkBoxIsActual.Checked = tour.IsActual;
            numericUpDownTicket.Value = tour.TicketCount;
    
            comboBoxCountry.SelectedItem = comboBoxCountry.Items
                .Cast<Country>()
                .FirstOrDefault(x => x.Code == tour.CountryCode); 
            
            var ids = tour.Types.Select(x=>x.Id).ToList();
            for( int i = 0; i < checkedListBox.Items.Count; i++) 
            {
                if (ids.Contains(((Type)checkedListBox.Items[i]).Id))
                {
                    checkedListBox.SetItemChecked(i, true);
                }
                    
            }
            
        }

        public Tour Tour => tour;

        public List<int> GetTypeIdsChecked()
        => checkedListBox.CheckedItems
            .Cast<Type>()
            .Select(x => x.Id)
            .ToList();
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            tour.Name = textBoxName.Text;
            ValidateTour();
        }

        private void ValidateTour()
        {
            butAdd.Enabled =
                !string.IsNullOrWhiteSpace(tour.Name) &&
                 decimal.TryParse(textBoxPrice.Text.ToString(), out decimal price);
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if(decimal.TryParse(textBoxPrice.Text.Trim(), out decimal price) && price > 0)
            {
                tour.Price = price;
            }
            ValidateTour();
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void checkBoxIsActual_CheckedChanged(object sender, EventArgs e)
        {
            tour.IsActual = checkBoxIsActual.Checked;
        }

        private void numericUpDownTicket_ValueChanged(object sender, EventArgs e)
        {
            tour.TicketCount = (int)numericUpDownTicket.Value;
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            tour.CountryCode = ((Country)comboBoxCountry.SelectedItem).Code;
        }

        private void butDelete_Click(object sender, EventArgs e)
        {

        }

        private void butAdd_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
