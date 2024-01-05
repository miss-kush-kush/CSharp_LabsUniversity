using FakturaForms.DataContext;
using FakturaForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakturaForms
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddFaktura();
        }

        private void AddFaktura()
        {
            if (!string.IsNullOrWhiteSpace(Numer_txt.Text))
            {
                try
                {
                    var newFaktura = new Faktura
                    {
                        Numer = Numer_txt.Text
                    };

                    using (var context = new AppDbContext())
                    {
                        using (var transaction = context.Database.BeginTransaction())
                        {
                            try
                            {
                                context.Faktury.Add(newFaktura);
                                context.SaveChanges();

                                transaction.Commit();
                                MessageBox.Show("Faktura added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                // Rollback the transaction in case of an error
                                transaction.Rollback();
                                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please provide a value for 'Numer'.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void AddPozycja_btn_Click(object sender, EventArgs e)
        {
            AddPozycja();
        }

        private void AddPozycja()
        {
            if (!string.IsNullOrWhiteSpace(FakId_txt.Text) && !string.IsNullOrWhiteSpace(Nazwa_txt.Text))
            {
                try
                {
                    decimal fakturaId = decimal.Parse(FakId_txt.Text);
                    decimal pozycjaWartosc;

                    // Using TryParse to set a default value if the parsing fails
                    if (!decimal.TryParse(PozWartosc_txt.Text, out pozycjaWartosc))
                    {
                        pozycjaWartosc = 0; // Default value if not provided or invalid
                    }

                    using (var context = new AppDbContext())
                    {
                        using (var transaction = context.Database.BeginTransaction())
                        {
                            try
                            {
                                var newPozycja = new Pozycja
                                {
                                    FakturaId = fakturaId,
                                    Nazwa = Nazwa_txt.Text,
                                    Wartosc = pozycjaWartosc
                                };

                                context.Pozycje.Add(newPozycja);
                                context.SaveChanges();

                                // Create a save point here
                                transaction.CreateSavepoint("BeforeUpdatingFaktura");

                                var faktura = context.Faktury.FirstOrDefault(f => f.FakturaId == fakturaId);
                                if (faktura != null)
                                {
                                    faktura.Wartosc = context.Pozycje.Where(p => p.FakturaId == fakturaId).Sum(p => p.Wartosc);
                                    context.SaveChanges();
                                }

                                transaction.Commit();
                                MessageBox.Show("Pozycja added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                // If something goes wrong, roll back to the save point
                                transaction.RollbackToSavepoint("BeforeUpdatingFaktura");
                                throw;
                            }
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid format for FakturaId.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please provide values for FakId and Nazwa.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



    }
}
