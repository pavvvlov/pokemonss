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
            dgvPokemons.DataSource = p.GetAllPokemons();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pokemon pokemon = new pokemon();
            pokemon.Tyoe = txtType.Text;
            pokemon.Type = txtType.Text;
            pokemon.Name = txtName.Text;
            
            p.CreatePokemons(pokemon);

            refreshTable();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvPokemons.CurrentRow;
            int id = int.Parse(row.Cells["Id"].Value.ToString());
            pokemon pokemon = new pokemon();
            pokemon.Id = id;
            pokemon.Type = txtType.Text;
            pokemon.Tyoe = txtType.Text;
            p.Updatepokemon(id, pokemon);
            refreshTable();
        }
    }
}
