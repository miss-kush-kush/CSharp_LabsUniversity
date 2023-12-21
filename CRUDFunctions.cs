using DBUsage.DataContext;
using DBUsage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DBUsage
{
    public static class CRUDFunctions
    {
        public static void AddFaktura(string number, decimal value)
        {

            using (var context = new AppDbContext())
            {
                var faktura = new Faktura { Numer = number, Wartosc = value };
                context.Faktury.Add(faktura);
                context.SaveChanges();
            }

        }

        public static void ViewFaktury()
        {
            using (var context = new AppDbContext())
            {
                var faktury = context.Faktury.ToList();
                foreach (var faktura in faktury)
                {
                    WriteLine($"ID: {faktura.FakturaId}, Number: {faktura.Numer}, Value: {faktura.Wartosc}");
                }
            }
        }

        public static void UpdateFaktura(int id, decimal value)
        {
            using (var context = new AppDbContext())
            {
                var faktura = context.Faktury.FirstOrDefault(f => f.FakturaId == id);
                if (faktura != null)
                {
                    faktura.Wartosc = value;
                    context.SaveChanges();
                    WriteLine("Faktura updated successfully.");
                }
                else
                {
                    WriteLine("Faktura not found.");
                }
            }
        }

        public static void DeleteFaktura(int id)
        {

            using (var context = new AppDbContext())
            {
                var faktura = context.Faktury.FirstOrDefault(f => f.FakturaId == id);
                if (faktura != null)
                {
                    context.Faktury.Remove(faktura);
                    context.SaveChanges();
                    WriteLine("Faktura deleted successfully.");
                }
                else
                {
                    WriteLine("Faktura not found.");
                }
            }
        }
    }
}
