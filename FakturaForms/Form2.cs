using FakturaForms.DataContext;
using FakturaForms.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FakturaForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadFakturyData();
            
        }
        private void LoadFakturyData()
        {
            using (var context = new AppDbContext())
            {

                var fakturyData = context.Faktury
                    .Select(f => new
                    {
                        f.FakturaId,
                        f.Numer,
                        Wartosc = f.Pozycje.Sum(p => p.Wartosc),
                        PozycjeCount = f.Pozycje.Count
                    })
                    .ToList();
                dataGridView1.DataSource = fakturyData;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var fakturaId = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["FakturaId"].Value);
                LoadPozycjeData(fakturaId);
            }
        }

        private void LoadPozycjeData(decimal fakturaId)
        {
            using (var context = new AppDbContext())
            {
                var pozycjeData = context.Pozycje
                    .Where(p => p.FakturaId == fakturaId)
                    .Select(p => new
                    {
                        p.PozycjaId,
                        p.FakturaId,
                        p.Nazwa,
                        p.Wartosc
                    })
                    .ToList();
                dataGridView2.DataSource = pozycjeData;
            }
        }
    }
}
