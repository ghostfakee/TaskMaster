using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool alterado;
        int zoom = 100;
        public Form1()
        {
            InitializeComponent();
            this.Text = "";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!alterado)
            {
                this.abrir();
            }
            else
            {
                if(MessageBox.Show("Seu arquivo foi alterado. Deseja salvar?", "TeskMaster", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.abrir();
                }
                else
                {
                    if(this.Text != "")
                    {
                        //significa que ja tem um arquivo aberto
                        this.salvar(this.Text);
                    }
                    else
                    {
                        this.salvarComo();
                    }
                }
            }

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rchTxtBxConteudo_TextChanged(object sender, EventArgs e)
        {
            alterado = true;
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrir()
        {
            if (opnFlDlgAbrir.ShowDialog() == DialogResult.OK)
            {
                //coloca o nome do arquivo como titulo do formulario
                this.Text = opnFlDlgAbrir.FileName;
                using (StreamReader reader = new StreamReader(opnFlDlgAbrir.OpenFile()))
                {
                    rchTxtBxConteudo.Rtf = reader.ReadToEnd();
                    alterado = false;
                }
            }
        }

        private void salvar(String arquivo)
        {
            if(arquivo != "")
            {
                StreamWriter buffer = new StreamWriter(arquivo);
                buffer.Write(rchTxtBxConteudo.Rtf);
                buffer.Close();
                this.Text = arquivo;
                alterado = false;
            }
            else
            {
                MessageBox.Show("Nome de arquivo inválido!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvarComo()
        {
            if (svFlDlgAbrir.ShowDialog() == DialogResult.OK)
            {
                this.salvar(svFlDlgAbrir.FileName);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.Text != "")
                    {
                //significa que ja tem um arquivo aberto
                this.salvar(this.Text);
            }
                    else
            {
                this.salvarComo();
            }
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.salvarComo();
        }

        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchTxtBxConteudo.Undo();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBxConteudo.SelectedRtf != "")
            {
                Clipboard.SetDataObject(rchTxtBxConteudo.SelectedRtf);
                rchTxtBxConteudo.SelectedRtf = "";
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(rchTxtBxConteudo.SelectedRtf);
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                rchTxtBxConteudo.SelectedRtf = (string)Clipboard.GetData(DataFormats.Text);
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBxConteudo.SelectedRtf != "")
            {
                rchTxtBxConteudo.SelectedRtf = "";
            }
        }

        private void buscarComOBingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBxConteudo.SelectedRtf != "")
            {
                string texto = rchTxtBxConteudo.SelectedText;
                texto.Replace(' ', '+');
                System.Diagnostics.Process.Start("microsoft-edge:http://www.bing.com/search?q=" + texto);
            }
            else
            {
                MessageBox.Show("é necessário ter algum texto selecionado para ser pesquisado", "buscar com o Bing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pesquisarDiretoNoChatGPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rchTxtBxConteudo.SelectedText))
            {
                string texto = rchTxtBxConteudo.SelectedText;
                Clipboard.SetText(texto);

                System.Diagnostics.Process.Start("microsoft-edge:https://chat.openai.com/");

                MessageBox.Show("O texto foi compiado para a área de transferência. Cole-o no CahtGPT para iniciar a conversa");
            }
            else
            {
                MessageBox.Show("selecionae um texto para buscar no ChatGPT");
            }
        }

        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchTxtBxConteudo.SelectAll();
        }

        private void horadataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchTxtBxConteudo.SelectedText = System.Environment.NewLine + DateTime.Now;
        }

        private void quebraAutomáticaDeLinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quebraAutomáticaDeLinhaToolStripMenuItem.CheckState == CheckState.Checked)
            {
                quebraAutomáticaDeLinhaToolStripMenuItem.CheckState = CheckState.Unchecked;
                rchTxtBxConteudo.WordWrap = false;

            }
            else
            {
                quebraAutomáticaDeLinhaToolStripMenuItem.CheckState = CheckState.Checked;
                rchTxtBxConteudo.WordWrap = true;
            }
        }

        private void configurarPáginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pgStpDlgConfiguraPagina.ShowDialog();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prImprimirntDlg.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!alterado)
            {
                this.Text = "";
                rchTxtBxConteudo.Text = "";
            }
            else
            {
                if (MessageBox.Show("Seu arquivo foi alterado. Deseja salvar?", "TeskMaster", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.Text = "";
                    rchTxtBxConteudo.Text = "";
                }
                else
                {
                    if (this.Text != "")
                    {
                        //significa que ja tem um arquivo aberto
                        this.salvar(this.Text);
                    }
                    else
                    {
                        this.salvarComo();
                    }
                }
            }
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fntDlgFonte.ShowDialog() == DialogResult.OK)
            {
                rchTxtBxConteudo.SelectionFont = fntDlgFonte.Font;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;

                string prompt = rchTxtBxConteudo.SelectedText;
                string resposta = await ChamarApiChatGPTAsync(prompt);

                richTextBoxResposta.Text = resposta;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
            finally
            {
                button1.Enabled = true;
            }
            string perguntaUsuario = textBoxPergunta.Text;

            if (!string.IsNullOrWhiteSpace(perguntaUsuario))
            {
                string resposta = await ChamarApiChatGPTAsync(perguntaUsuario);
                richTextBoxResposta.Text = resposta;
            }
            else
            {
                MessageBox.Show("Por favor, digite uma mensagem.");
            }
        }
        private static async Task<string> ChamarApiChatGPTAsync(string prompt)
        {
            string apiKey = "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";
            string apiUrl = "https://api.openai.com/v1/chat/completions";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                var requestBody = new
                {
                    model = "gpt-3.5-turbo",
                    messages = new[]
                    {
                        new {role = "user", content = prompt }
                    },
                    max_tokens = 150
                };

                var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync(apiUrl, content);

                    if ((int)response.StatusCode == 429)
                    {
                        Console.WriteLine("Limite de requisições excedido. Aguardando 2 segundos...");
                        await Task.Delay(2000); // Atraso de 2 segundos

                        content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");
                        response = await client.PostAsync(apiUrl, content);
                    }
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        dynamic parsedResponse = JsonConvert.DeserializeObject(jsonResponse);

                        return parsedResponse.choices[0].message.content.ToString();
                    }
                    else
                    {
                        return $"Erro: {response.StatusCode} - {response.ReasonPhrase}";
                    }
                }
                catch (Exception ex)
                {
                    return $"Erro ao fazer requisição: {ex.Message}";
                }
            }
        }
    }   
}
