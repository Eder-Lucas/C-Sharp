using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroApp
{
    public partial class frmVizualizadorImagens : Form
    {
        public frmVizualizadorImagens()
        {
            InitializeComponent();   
        }

        bool loadImage = false; //Verifica quando a imagem foi carregada
    
        //Quando clicar no botao Mostrar Imagem
        private void btnMostraImagem_Click(object sender, EventArgs e)
        {
            //Abre uma janela e se o usuario escolher uma imagem
            if (ofdImagens.ShowDialog() == DialogResult.OK)
            {
                pbImagens.Load(ofdImagens.FileName); //Carrega ela no PictureBox
                btnMostraImagem.Enabled = false; //Desativa o botao evitando novos envios
                loadImage = true; //Indica que a imagem foi carregada

                //Torna a visualizacao da imagem automatica sem depender de um novo click no RadioButton
                if (rbStretch.Checked) //Se o stretch tiver marcado
                {
                    pbImagens.SizeMode = PictureBoxSizeMode.StretchImage; //Troca pra o modo Stretch
                }
                else                                                    //senao
                {
                    pbImagens.SizeMode = PictureBoxSizeMode.Normal; //Troca pra o modo normal
                }
            }
        }

        //Quando clicar no botao Limpar imagem
        private void btnLimpaImagem_Click(object sender, EventArgs e)
        {
            pbImagens.Image = Properties.Resources.drop; //Adiciona a imagem que simboliza que nao ha imagens adicionadas
            pbImagens.SizeMode = PictureBoxSizeMode.StretchImage; //Forca a troca pro modo stretch
            btnMostraImagem.Enabled = true; //Ativa o botao para carregar uma nova imagem
            loadImage = false; //Indica que nao tem uma imagem carregada
        }

        //Quando o botao radio Stretch for marcado
        private void rbStretch_CheckedChanged(object sender, EventArgs e)
        {
            if (loadImage) //Se tiver imagem carregada
            {
                pbImagens.SizeMode = PictureBoxSizeMode.StretchImage; //Troca pra o modo Stretch
            }
        }

        //Quando o botao radio Normal for marcado
        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (loadImage) //Se tiver imagem carregada
            {
                pbImagens.SizeMode = PictureBoxSizeMode.Normal; //Troca pra o modo Normal
            }
        }
    }
}
