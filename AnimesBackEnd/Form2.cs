using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimesBackEnd
{
    public partial class Form2 : Form
    {

        
        public Form2()
        {
            InitializeComponent();
        }
       
        string url = "";
        private void Form2_Load(object sender, EventArgs e)
        {
            btnAtualiza.Enabled = false;
            btnDeleta.Enabled = false;
            GetTemporada();
            GetAllEpisodios();
        }


        //CARREGA LISTA DE TEMPORADAS GET ID
        #region
        private async void GetTemporada()
        {

            String Url="";
            ConvertJsonObject.JsonConversao jsonconvert = new ConvertJsonObject.JsonConversao();
            List<Temporada> temporada = new List<Temporada>();
            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                Url = "";
                HttpResponseMessage response = await client.GetAsync(Url);
                if (response.IsSuccessStatusCode)
                {
                    var TemporadaJsonString = await response.Content.ReadAsStringAsync();


                    temporada = JsonConvert.DeserializeObject<List<Temporada>>(TemporadaJsonString);


                    foreach(var temp in temporada)
                    {
                        cmbTemporada.ValueMember ="Id";
                        cmbTemporada.DisplayMember= "Descricao";
                        
                       // cmbTemporada.ValueMember = temp.Id.ToString();
                        cmbTemporada.DataSource = temporada;


                    }
                    
                    
                  
                }
                else
                {
                    MessageBox.Show("Falha ao obter o temporada : " + response.StatusCode);
                }
            }
        }
        #endregion
        private async void GetTemporadaId()
        {

            String Url = "";
            ConvertJsonObject.JsonConversao jsonconvert = new ConvertJsonObject.JsonConversao();
            List<Temporada> temporada = new List<Temporada>();
            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                Url = "" + txtTempId.Text;
                HttpResponseMessage response = await client.GetAsync(Url);
                if (response.IsSuccessStatusCode)
                {
                    var TemporadaJsonString = await response.Content.ReadAsStringAsync();


                    temporada = JsonConvert.DeserializeObject<List<Temporada>>(TemporadaJsonString);


                    foreach (var temp in temporada)
                    {
                        cmbTemporada.ValueMember = "Id";
                        cmbTemporada.DisplayMember = "Descricao";

                        // cmbTemporada.ValueMember = temp.Id.ToString();
                        cmbTemporada.DataSource = temporada;


                    }



                }
                else
                {
                    MessageBox.Show("Falha ao obter o temporada : " + response.StatusCode);
                }
            }
        }



        //GET
        #region
        private async void GetAllEpisodios()
        {
            url =txtUrlEpisodios.Text;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var EpisodioJsonString = await response.Content.ReadAsStringAsync();
                        dgvEpisodio.DataSource = JsonConvert.DeserializeObject<EpisodioComID[]>(EpisodioJsonString);
                        
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o Episodios : " + response.StatusCode);
                    }
                }
            }
        }
        #endregion

        //GET BY ID
        #region
        private async void GetAnimeId(int codEpisodio)
        {
            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
               url =txtUrlEpisodios.Text + "/" + txtIdEpisodio.Text;
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var EpisodioJsonString = await response.Content.ReadAsStringAsync();

                    bsDados.DataSource = JsonConvert.DeserializeObject<EpisodioComID[]>(EpisodioJsonString);
                    dgvEpisodio.DataSource = bsDados.Sort.Reverse();
                }
                else
                {
                    MessageBox.Show("Falha ao obter o episodio : " + response.StatusCode);
                }
            }
        }
        #endregion

        #region ADICIONAR EPISODIOS A TEMPORADA

        private async void AddEpisodio()
        {
            url = "";
            Episodio episodio = new Episodio();
            episodio.UrlImage = txtUrlImage.Text;
            episodio.UrlVideo = txtUrlVideo.Text;
            episodio.Descricao = txtDescricao.Text;
            episodio.NumEpsodio = int.Parse(txtNumEpisodio.Text);
           



            using (var client = new HttpClient())
            {
                try
                {
                    var serializedProduto = JsonConvert.SerializeObject(episodio);
                    var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(url+txtTempId.Text+"/episodios", content);



                    if (result.IsSuccessStatusCode )
                    {
                       if( cmbTemporada.SelectedIndex > 0 && MessageBox.Show("Adicionar episodio a temporada id:" + txtTempId.Text, "Episodio", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        MessageBox.Show("Episodio " + episodio + " incluido com sucesso " );                       
                        GetAllEpisodios();
                        int recebido = int.Parse(txtNumEpisodio.Text) + 1;
                        txtNumEpisodio.Text = recebido.ToString();

                    }


                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao incluir anime: " + e);
                    int recebido = int.Parse(txtNumEpisodio.Text) - 1;
                    txtNumEpisodio.Text = recebido.ToString();
                }
            }



        }


        #endregion



        private  async void UpdateEpisodio()
        {
            url = "";
            EpisodioPut episodio = new EpisodioPut();           
            episodio.UrlImage = txtUrlImage.Text;
            episodio.UrlVideo = txtUrlVideo.Text;
            episodio.Descricao = txtDescricao.Text;
            episodio.NumEpsodio = int.Parse(txtNumEpisodio.Text);

            using (var client = new HttpClient())
            {


              
              //  var response = client.PutAsJsonAsync(txtIdEpisodio.Text, episodio).Result;
               //   var resultTemporada = await client.PutAsJsonAsync(url + "/" + txtIdEpisodio.Text, );
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(url + txtIdEpisodio.Text, episodio);
                try
                {
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Episodio atualizado");
                        GetAllEpisodios();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar o Episodio : " + responseMessage.StatusCode);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Falha ao atualizar o episodio : " + e);
                }
            }

        }


        private async void DeleteEpisodio()
        {
            url = "";
            int epId = int.Parse(txtIdEpisodio.Text);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                HttpResponseMessage responseMessage = await
                    client.DeleteAsync(String.Format("{0}/{1}", url, epId));

                try
                {
                    if (MessageBox.Show("Deseja deletar episodio? ?", "Episodio", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (responseMessage.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Episodio excluído com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao excluir o episodio  : " + responseMessage.StatusCode);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro: " + e);
                }

            }
            GetAllEpisodios();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtIdEpisodio.TextLength > 0))
            {
                GetAnimeId(int.Parse(txtIdEpisodio.Text));

            }
            else
            {
                MessageBox.Show("Deve inserir um id para busca!");
                txtIdEpisodio.Focus();
            }
            
        }

        private void cmbTemporada_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtTempId.Text = cmbTemporada.SelectedValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {



            AddEpisodio();
            txtUrlImage.Focus();
        }

        private void dgvEpisodio_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            // Try to sort based on the cells in the current column.
          /*  e.SortResult = System.String.Compare(
                e.CellValue1.ToString(), e.CellValue1.ToString());

            // If the cells are equal, sort based on the ID column.
            if (e.SortResult == 0 && e.Column.Name == "Id")
            {
                e.SortResult = System.String.Compare(
                    dgvEpisodio.Rows[e.RowIndex1].Cells["Id"].Value.ToString(),
                    dgvEpisodio.Rows[e.RowIndex2].Cells["Id"].Value.ToString());
            }
            e.Handled = true;*/
        }

        private void dgvEpisodio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdEpisodio.Text =  dgvEpisodio.CurrentRow.Cells[0].Value.ToString();
            txtUrlImage.Text = dgvEpisodio.CurrentRow.Cells[1].Value.ToString();
            txtUrlVideo.Text = dgvEpisodio.CurrentRow.Cells[2].Value.ToString();
            txtDescricao.Text = dgvEpisodio.CurrentRow.Cells[3].Value.ToString();
            txtNumEpisodio.Text = dgvEpisodio.CurrentRow.Cells[4].Value.ToString();
            if (txtIdEpisodio.TextLength > 0)
            {
                btnAtualiza.Enabled = true;
                btnDeleta.Enabled = true;
            }
            else
            {
                btnAtualiza.Enabled = false;
                btnDeleta.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtIdEpisodio.TextLength <= 0 || txtUrlImage.TextLength<=0)
            {
                MessageBox.Show("Selecione um episodio na lista para atualziar!");
            }
            else
            {
                UpdateEpisodio();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteEpisodio();
        }
    }
}
