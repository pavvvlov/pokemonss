using pokemons.Controllers;
using pokemons.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemons
{
    public partial class pokemonsView : Form
    {
        pokemonsController p = new pokemonsController();

        public pokemonsView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void refreshTable()
        {
            throw new NotImplementedException();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pokemon pokemon = new pokemon();
            pokemon.Type = txtType.Text;
            pokemon.Name = txtName.Text;
            
            p.CreatePokemons(pokemon);

            refreshTable();
            
        }
    }
}
