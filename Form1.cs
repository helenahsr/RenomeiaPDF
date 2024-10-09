using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using EasyAutomationFramework;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RenomeiaPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscolhePasta_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        public void ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDiretorio.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnRodar_Click(object sender, EventArgs e)
        {
            //Pegando o diretório
            string diretorio = txtDiretorio.Text; //Pega o diretório escolhido
            int cont = 0; //Contador para o número de arquivos inválidos
            DirectoryInfo dir = new DirectoryInfo(diretorio); //Cria um objeto para representar o diretório
            FileInfo[] arquivosPdf = dir.GetFiles("*.pdf"); // Lista todos os arquivos .pdf no diretório informado

            foreach (FileInfo arquivo in arquivosPdf) //Foreach para percorrer cada arquivo
            {
                string caminho = "file:///" + arquivo.FullName; // Adicionando o file:// ao caminho do arquivo para o pdf poder ser lido pelo framework

                try
                {
                    var text = Base.ExtractTextPdf(caminho); //Extraindo todo o texto do arquivo
                    caminho = new Uri(caminho).LocalPath; //Retirando o file:// para podermos renomea-lo depois
                    var placa = text.IndexOf("Placa:"); //Procurando o campo placa
                    var teste = text.Substring(placa + 7, 7); // Pegando a placa
                    string padraoPlaca = @"^[A-Z]{3}\d{4}$"; // Criando o padrão de placa antiga
                    string padrao2 = "^[A-Z]{3}\\d[A-Z]\\d{2}$"; // Criando o padrão de placa atual (Mercosul)
                    if (Regex.IsMatch(teste, padraoPlaca) || Regex.IsMatch(teste, padrao2)) // Testando se o que foi pego está no padrão, ou seja, testando se é uma placa
                    {
                        var newNome = teste + ".pdf"; //Caso sim, setaremos o novo nome com o valor da placa mais o ".pdf"
                        File.Move(caminho, Path.Combine(Path.GetDirectoryName(caminho), newNome)); //Encontrando o arquivo e o renomeando.
                    }
                    else
                    {
                        lstLog.Items.Add($"O documento {arquivo} não contém placa ou a placa não está no formato válido."); //Caso não, informaremos que não foi possível
                        cont++; // Adicionaremos mais um ao contador
                        var newNome = $"invalido{cont}.pdf"; // setando o novo nome do arquivo sem placa ou inválido
                        File.Move(caminho, Path.Combine(Path.GetDirectoryName(caminho), newNome)); // Encontrando e renomeando o arquivo
                    }

                }
                catch (Exception ex) // Caso haja problemas na leitura de algum arquivo
                {
                    lstLog.Items.Add($"Erro ao processar o arquivo {arquivo.Name}: {ex.Message}");
                }
            }

            //Terminando o programa
            lstLog.Items.Add("\nConcluído!");
        }
    }
}
