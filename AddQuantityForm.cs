using System;
using System.Data.Entity; // <-- Fontos a .FindAsync()-hoz
using System.Linq;
using System.Windows.Forms;

namespace wshop
{
    public partial class AddQuantityForm : Form
    {
        public AddQuantityForm()
        {
            InitializeComponent();
        }

        // A "Hozzáadás" gomb eseménye (Async)
        // (A gomb neve legyen 'btnAdauga')
        private async void btnAdauga_Click(object sender, EventArgs e)
        {
            // --- 1. Validálás ---
            int produsId;
            if (!int.TryParse(txtProdusId.Text, out produsId)) // TextBox neve: txtProdusId
            {
                MessageBox.Show("ID-ul produsului trebuie să fie un număr!");
                return;
            }

            int cantitateDeAdaugat;
            if (!int.TryParse(txtCantitate.Text, out cantitateDeAdaugat) || cantitateDeAdaugat <= 0) // TextBox neve: txtCantitate
            {
                MessageBox.Show("Cantitatea trebuie să fie un număr pozitiv!");
                return;
            }

            // --- 2. Adatbázis művelet (Async) ---
            try
            {
                using (var db = new MagazinDbContext())
                {
                    // 6. Követelmény: Aszinkron keresés
                    Produs produsDeActualizat = await db.Produse.FindAsync(produsId);

                    if (produsDeActualizat != null)
                    {
                        produsDeActualizat.Cant += cantitateDeAdaugat;

                        // 6. Követelmény: Aszinkron mentés
                        await db.SaveChangesAsync();

                        MessageBox.Show($"Cantitate adăugată cu succes! \nNoua cantitate: {produsDeActualizat.Cant}");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nu a fost găsit niciun produs cu acest ID!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a mentés közben: " + ex.Message);
            }
        }

        // Designer által generált üres Load, ha van
        private void AddQuantityForm_Load(object sender, EventArgs e) { }
    }
}