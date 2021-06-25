using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimesBackEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                
        }
       // string Url = "";
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disableBtn();
            GetAllAnimes();
        }

       

        private void gdvDadosAnime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtId.Text = gdvDadosAnime.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = gdvDadosAnime.CurrentRow.Cells[1].Value.ToString(); ;
            txtNomeAlternativo.Text = gdvDadosAnime.CurrentRow.Cells[2].Value.ToString(); 
            txtSinopse.Text = gdvDadosAnime.CurrentRow.Cells[3].Value.ToString();
            txtUrlPoster.Text = gdvDadosAnime.CurrentRow.Cells[4].Value.ToString(); 
            txtAutor.Text = gdvDadosAnime.CurrentRow.Cells[5].Value.ToString(); 
            txtEstudio.Text = gdvDadosAnime.CurrentRow.Cells[6].Value.ToString();
            txtStatus.Text = gdvDadosAnime.CurrentRow.Cells[7].Value.ToString(); ;
            txtAno.Text = gdvDadosAnime.CurrentRow.Cells[8].Value.ToString(); ;
            txtNumEpisodios.Text = gdvDadosAnime.CurrentRow.Cells[9].Value.ToString(); 
            txtTemporadas.Text = gdvDadosAnime.CurrentRow.Cells[10].Value.ToString();
            txtLikes.Text = gdvDadosAnime.CurrentRow.Cells[11].Value.ToString();

            txtIdAnimeTemporada.Text = txtId.Text;
            txtDescricaoTemporada.Text = txtNome.Text;
            if (txtId.TextLength > 0)
            {
                btnAtualizaAnime.Enabled = true;
                btnDeletaAnime.Enabled = true;
            }
            else
            {
                btnAtualizaAnime.Enabled = false;
            }
        }



        //metodos para fazer as requisições

           //GET
        private async void GetAllAnimes()
        {
            Url = txtUrl.Text;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(Url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        gdvDadosAnime.DataSource = JsonConvert.DeserializeObject<Anime[]>(ProdutoJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }
        }


        //GET BY ID
        private async void GetProdutoById(int codProduto)
        {
            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                Url = txtUrl.Text + "/" + txtId.Text.ToString();
                HttpResponseMessage response = await client.GetAsync(Url);
                if (response.IsSuccessStatusCode)
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    bsDados.DataSource = JsonConvert.DeserializeObject<Anime>(ProdutoJsonString);
                    gdvDadosAnime.DataSource = bsDados;
                }
                else
                {
                    MessageBox.Show("Falha ao obter o produto : " + response.StatusCode);
                }
            }
        }

        //ADD NOVO ANIME POST
        private async void AddAnime()
        {
            Url = txtUrl.Text;
            Anime anime = new Anime();
            anime.id = int.Parse(txtId.Text);
            anime.nome=   txtNome.Text;
            anime.nomeAlternativo= txtNomeAlternativo.Text ;
            anime.sinopse= txtSinopse.Text ;
            anime.urlPoster= txtUrlPoster.Text ;
            anime.autor= txtAutor.Text ;
            anime.estudio=txtEstudio.Text ;
            anime.status= txtStatus.Text  ;
            anime.ano= int.Parse(txtAno.Text ) ;
            anime.numEpisodios= int.Parse(txtNumEpisodios.Text) ;
            anime.temporadas= int.Parse(txtTemporadas.Text) ;
            anime.likes = int.Parse(txtLikes.Text) ;
                        
            

            using (var client = new HttpClient())
            {
                try
                {
                    var serializedProduto = JsonConvert.SerializeObject(anime);
                    var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Url, content);

                   

                    if (result.IsSuccessStatusCode)
                    {

                        MessageBox.Show("Anime " + anime.nome + " incluido com sucesso " + anime.id );                       
                        txtIdAnimeTemporada.Text = anime.id.ToString();
                        AddTemporada();



                        GetAllAnimes();

                        if (cmbLetra.SelectedIndex>1 && MessageBox.Show("Associar temporada ao anime? e letra", "Temporada e letra", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            
                            AddLetra(txtIdAnimeTemporada.Text);
                        }
                    }
                 

                }
                catch( Exception e)
                {
                    MessageBox.Show("Erro ao incluir anime: " + e);
                }
            }
            

           
        }

        //INCLUIR POST TEMPORADA
        private async void AddTemporada()
        {
            Url = "";


            TemporadaAdd temporada = new TemporadaAdd();
            Anime anime = new Anime();
            temporada.Descricao = txtDescricaoTemporada.Text;          
            



            using (var client = new HttpClient())
            {


                var serializedTemporada = JsonConvert.SerializeObject(temporada);
                var contentTemporada = new StringContent(serializedTemporada, Encoding.UTF8, "application/json");
                var resultTemporada = await client.PostAsync(Url + txtIdAnimeTemporada.Text+ "/temporadas", contentTemporada);
                try
                {
                    if (resultTemporada.IsSuccessStatusCode)
                    {

                        MessageBox.Show("Temporada associada " + temporada.Descricao);
                        temporada.Descricao = txtDescricaoTemporada.Text;

                        GetAllAnimes();


                    }
                    else
                    {
                        MessageBox.Show("Temporada erro " + resultTemporada.ReasonPhrase);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Temporada erro: " + e);
                }

            }
        }

        //INCLUIR LETRA AO ANIME POST
        private async void AddLetra(string id)
        {
            Url = "";


            Alfabeto alfabeto = new Alfabeto();
           
            alfabeto.letra = cmbLetra.Text;




            using (var client = new HttpClient())
            {


                var serializedLetra = JsonConvert.SerializeObject(alfabeto);
                var contentLetra = new StringContent(serializedLetra, Encoding.UTF8, "application/json");
                var resultLetra = await client.PostAsync(Url + id + "/alfabetos", contentLetra);
                try
                {
                    if (resultLetra.IsSuccessStatusCode)
                    {

                        MessageBox.Show("Letra associada " + alfabeto.letra);
                       

                        GetAllAnimes();


                    }
                    else
                    {
                        MessageBox.Show("Letra erro " + resultLetra.ReasonPhrase);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Letra erro: " + e);
                }

            }
        }




        //ATUALIZAR ANIME PUT
        private async void UpdateAnime()
        {
            Url = txtUrl.Text;
            AnimePut anime = new AnimePut();          
            anime.nome = txtNome.Text;
            anime.nomeAlternativo = txtNomeAlternativo.Text;
            anime.sinopse = txtSinopse.Text;
            anime.urlPoster = txtUrlPoster.Text;
            anime.autor = txtAutor.Text;
            anime.estudio = txtEstudio.Text;
            anime.status = txtStatus.Text;
            anime.ano = int.Parse(txtAno.Text);
            anime.numEpisodios = int.Parse(txtNumEpisodios.Text);
            anime.temporadas = int.Parse(txtTemporadas.Text);
            anime.likes = int.Parse(txtLikes.Text);

            using (var client = new HttpClient())
            {


                client.BaseAddress = new Uri("");
                var response = client.PutAsJsonAsync(txtId.Text, anime).Result;
              //  var resultTemporada = await client.PutAsJsonAsync(Url + "/" + txtId.Text, contentTemporada);
               // HttpResponseMessage responseMessage = await client.PutAsJsonAsync(Url + "/" + anime.id,anime);
                try
                {
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Anime atualizado");
                        GetAllAnimes();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar o anime : " + response.StatusCode);
                    }
                }catch(Exception e)
                {
                    MessageBox.Show("Falha ao atualizar o anime : " +e);
                }
            }
           
        }

        //DELETA ANIME DELETE
        private async void DeleteAnime(int codProduto)
        {
            Url = txtUrl.Text;
            int animeID = int.Parse(txtId.Text);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Url);
                HttpResponseMessage responseMessage = await
                    client.DeleteAsync(String.Format("{0}/{1}", Url, animeID));

                try
                {
                    if (MessageBox.Show("Deletar anime?", "Anime", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (responseMessage.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Anime excluído com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao excluir o anime  : " + responseMessage.StatusCode);
                        }
                    }
                }catch(Exception e)
                {
                    MessageBox.Show("Erro: "+ e);
                }
                 
            }
            GetAllAnimes();
        }

        private void btnIncluirAnime_Click(object sender, EventArgs e)
        {

            txtDescricaoTemporada.Text = txtNome.Text;

            if (
            txtNome.Text =="" && txtDescricaoTemporada.Text != txtNome.Text)
            {
                MessageBox.Show("Há campos obrigatorios");
                txtNome.Focus();
            }
            else
            {
                if(MessageBox.Show("Anime adicionado com sucesso", "Inclução", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    AddAnime();
                    
                }
                else
                {
                    MessageBox.Show("Cancelado inclução!", "Cancelado");
                }
               

            }
          
        }

        private void btnObterAnimeId_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Insira o id do anime:");
                btnAtualizaAnime.Enabled = false;
            }
            else
            {
                GetProdutoById(int.Parse(txtId.Text));
                btnAtualizaAnime.Enabled = true;
            }
        }

        private void btnAtualizaAnime_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" )
            {
                MessageBox.Show("Escolha um anime para atualiza-lo!");
                gdvDadosAnime. Focus();
            }else 
            {
                UpdateAnime();
               
            }
        }

        private void btnDeletaAnime_Click(object sender, EventArgs e)
        {
              if (int.Parse(txtId.Text) != -1)
            {
                DeleteAnime(int.Parse(txtId.Text));
            }
        }

      /*  private void btnTemporadaAssociar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja associar temporada ao anime agora?", "Associação", MessageBoxButtons.OKCancel) == DialogResult.OK && txtIdAnimeTemporada.Text !="")

            {
                AddTemporada(txtIdAnimeTemporada.Text);
            }
        }*/

        private void gdvDadosAnime_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNovoAnime_Click(object sender, EventArgs e)
        {
            txtId.Text = gdvDadosAnime.CurrentRow.Cells[0].Value.ToString();
            
            int recebido = int.Parse(txtId.Text)+1;
            txtId.Text = recebido.ToString();
            txtIdAnimeTemporada.Text = recebido.ToString();
            txtDescricaoTemporada.Text = txtNome.Text;


            //LIMPAR CAMPOS
            txtNome.Text ="" ;
            txtNomeAlternativo.Text = "";
            txtSinopse.Text ="";
            txtUrlPoster.Text = "";
            txtAutor.Text ="";
            txtEstudio.Text = "";
            txtStatus.Text = "" ;
            txtAno.Text ="" ;
            txtNumEpisodios.Text = "";
            txtTemporadas.Text ="";
            txtLikes.Text = "";
          

            if (txtId.TextLength>0){
                btnIncluirAnime.Enabled = true;
                btnDeletaAnime.Enabled = true;
                btnAtualizaAnime.Enabled = false;

            }
            else
            {
                btnDeletaAnime.Enabled = false;
                btnIncluirAnime.Enabled = false;
              
            }
           



        }


        private void disableBtn()
        {
            btnDeletaAnime.Enabled = false;
            btnAtualizaAnime.Enabled = false;
            btnIncluirAnime.Enabled = false;
        }

        private void btnAddEpisodioAnime_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();

            form2.Show();


        }

       

        private void btnLetra_Click(object sender, EventArgs e)
        {
           
            AddLetra(txtIdAnimeTemporada.Text);
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string buscar = txtLocaAnime.Text;

            foreach (DataGridViewRow row in this.gdvDadosAnime.Rows)
            {
                string busca = (row.Cells["nome"].Value.ToString());

                if (busca == buscar) ;
                  //rotina que colore  a linha;
            }
        }

        /*  private void gdvDadosAnime_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
          {
              DataGridViewColumn newColumn = gdvDadosAnime.Columns[e.ColumnIndex];
              DataGridViewColumn oldColumn = gdvDadosAnime.SortedColumn;
              ListSortDirection direction;

              // If oldColumn is null, then the DataGridView is not sorted.
              if (oldColumn != null)
              {
                  // Sort the same column again, reversing the SortOrder.
                  if (oldColumn == newColumn &&
                      gdvDadosAnime.SortOrder == SortOrder.Ascending)
                  {
                      direction = ListSortDirection.Descending;
                  }
                  else
                  {
                      // Sort a new column and remove the old SortGlyph.
                      direction = ListSortDirection.Ascending;
                      oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                  }
              }
              else
              {
                  direction = ListSortDirection.Ascending;
              }

              // Sort the selected column.
              gdvDadosAnime.Sort(newColumn, direction);
              newColumn.HeaderCell.SortGlyphDirection =
                  direction == ListSortDirection.Ascending ?
                  SortOrder.Ascending : SortOrder.Descending;
          }*/

        /*   private void gdvDadosAnime_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
           {
               foreach (DataGridViewColumn column in gdvDadosAnime.Columns)
               {
                   column.SortMode = DataGridViewColumnSortMode.Programmatic;
               }
           }*/
    }
    


   
}
