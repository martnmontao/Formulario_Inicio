using Biblioteca_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Inicio
{
    public partial class Formulario_Inversiones : Form
    {
        private Usuario usuario;
        private double porcentajeRandomApple;
        private double porcentajeRandomMicrosoft;
        private double porcentajeRandomTesla;
        private double porcentajeRandomAmazon;
        private int contador;
        private string accion;
        private double gananciaFinal;
        Formulario_Ingresar_Sueldo fi = new Formulario_Ingresar_Sueldo();

        public Formulario_Inversiones()
        {
            InitializeComponent();
        }
        public Formulario_Inversiones(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.contador = 0;
            MostrarSueldos();
            tmrContador.Enabled = true;
        }


        private void btnInvertirApple_Click(object sender, EventArgs e)
        {

            if (VerificarInversion(usuario, txtInversionApple.Text))
            {
                contador = 0;
                accion = "apple";
                tmrContador.Enabled = true;
                MostrarBotones(false);
            }
            else
            {
                accion = "No";
            }

        }

        private void btnInvertirMicrosoft_Click(object sender, EventArgs e)
        {

            if (VerificarInversion(usuario, txtInversionMicrosoft.Text))
            {
                contador = 0;
                accion = "microsoft";
                tmrContador.Enabled = true;
                MostrarBotones(false);

            }
            else
            {
                accion = "No";
            }

        }

        private void btnInvertirTesla_Click(object sender, EventArgs e)
        {


            if (VerificarInversion(usuario, txtInversionTesla.Text))
            {
                contador = 0;
                accion = "tesla";
                tmrContador.Enabled = true;
                MostrarBotones(false);

            }
            else
            {
                accion = "No";
            }

        }

        private void btnInvertirAmazon_Click(object sender, EventArgs e)
        {

            if (VerificarInversion(usuario, txtInversionAmazon.Text))
            {
                contador = 0;
                accion = "amazon";
                tmrContador.Enabled = true;
                MostrarBotones(false);

            }
            else
            {
                accion = "No";
            }

        }

        private double generarPorcentajeRandom()
        {
            int min = -3;
            int max = 4;
            double porcentajeRandom;
            Random rnd = new Random();
            porcentajeRandom = rnd.NextDouble() * (min - max) + (max);
            porcentajeRandom = (Math.Truncate(porcentajeRandom * 10) / 10);
            return porcentajeRandom;
        }

        private void tmrContador_Tick(object sender, EventArgs e)
        {

            contador++;
            if (contador == 1 || contador == 5 || contador == 10 || contador == 15)
            {
                this.porcentajeRandomApple = generarPorcentajeRandom();
                this.porcentajeRandomMicrosoft = generarPorcentajeRandom();
                this.porcentajeRandomTesla = generarPorcentajeRandom();
                this.porcentajeRandomAmazon = generarPorcentajeRandom();
                if (porcentajeRandomApple > 0)
                {
                    lblNumeroInversionApple.ForeColor = Color.Green;
                }
                else
                {
                    lblNumeroInversionApple.ForeColor = Color.Red;
                }
                if (porcentajeRandomMicrosoft > 0)
                {
                    lblNumeroInversionMicrosoft.ForeColor = Color.Green;
                }
                else
                {
                    lblNumeroInversionMicrosoft.ForeColor = Color.Red;
                }
                if (porcentajeRandomTesla > 0)
                {
                    lblNumeroInversionTesla.ForeColor = Color.Green;
                }
                else
                {
                    lblNumeroInversionTesla.ForeColor = Color.Red;
                }
                if (porcentajeRandomAmazon > 0)
                {
                    lblNumeroInversionAmazon.ForeColor = Color.Green;
                }
                else
                {
                    lblNumeroInversionAmazon.ForeColor = Color.Red;

                }

                this.lblNumeroInversionApple.Text = porcentajeRandomApple.ToString();
                this.lblNumeroInversionMicrosoft.Text = porcentajeRandomMicrosoft.ToString();
                this.lblNumeroInversionTesla.Text = porcentajeRandomTesla.ToString();
                this.lblNumeroInversionAmazon.Text = porcentajeRandomAmazon.ToString();

                if (contador == 15)
                {
                    MostrarSueldos();
                    switch (accion)
                    {
                        case "apple":
                            usuario.Sueldo += GenerarGananciaFinal(txtInversionApple.Text, porcentajeRandomApple);
                            MostrarSueldos();
                            fi.ModificarSueldo(usuario, usuario.Sueldo, fi.ConvertirPesoADolar(usuario.Sueldo));
                            tmrContador.Enabled = false;
                            MostrarBotones(true);
                            break;
                        case "microsoft":
                            usuario.Sueldo = usuario.Sueldo += GenerarGananciaFinal(txtInversionMicrosoft.Text, porcentajeRandomMicrosoft);
                            MostrarSueldos();
                            fi.ModificarSueldo(usuario, usuario.Sueldo, fi.ConvertirPesoADolar(usuario.Sueldo));
                            tmrContador.Enabled = false;
                            MostrarBotones(true);
                            break;
                        case "tesla":
                            usuario.Sueldo = usuario.Sueldo += GenerarGananciaFinal(txtInversionTesla.Text, porcentajeRandomTesla);
                            MostrarSueldos();
                            fi.ModificarSueldo(usuario, usuario.Sueldo, fi.ConvertirPesoADolar(usuario.Sueldo));
                            tmrContador.Enabled = false;
                            MostrarBotones(true);
                            break;
                        case "amazon":
                            usuario.Sueldo = usuario.Sueldo += GenerarGananciaFinal(txtInversionAmazon.Text, porcentajeRandomAmazon);
                            MostrarSueldos();
                            fi.ModificarSueldo(usuario, usuario.Sueldo, fi.ConvertirPesoADolar(usuario.Sueldo));
                            tmrContador.Enabled = false;
                            MostrarBotones(true);
                            break;
                        default:
                            contador = 0;
                            break;
                    }

                }
            }

        }
        private double GenerarGananciaFinal(string sueldoInvertido, double porcentajeFinal)
        {
            this.gananciaFinal = double.Parse(sueldoInvertido) + (double.Parse(sueldoInvertido) * porcentajeFinal / 100);
            usuario.Sueldo = usuario.Sueldo + gananciaFinal;
            return gananciaFinal;
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            Formulario_Menu_Usuario fm = new Formulario_Menu_Usuario(usuario);
            fm.Show();
            this.Hide();

        }
        private bool VerificarInversion(Usuario usuario, string txtBox)
        {
            bool verificado = false;
            try
            {
                double inversion = double.Parse(txtBox);
                if (inversion <= usuario.Sueldo && inversion > 0)
                {
                    usuario.Sueldo = usuario.Sueldo - inversion;
                    lblSueldoPesos.Text = "$ARG: " + usuario.Sueldo.ToString();
                    lblSueldoDolar.Text = "$USD: " + fi.ConvertirPesoADolar(usuario.Sueldo).ToString();
                    verificado = true;
                }
                else if (inversion <= 0)
                {
                    MessageBox.Show("Ingrese una inversión válida.");
                }
                else
                {
                    MessageBox.Show("Ingrese un sueldo válido.");
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un sueldo.");
            }
            return verificado;
        }
        private void MostrarSueldos()
        {
            lblSueldoPesos.Text = "$ARG: " + usuario.Sueldo.ToString();
            lblSueldoDolar.Text = "$USD: " + fi.ConvertirPesoADolar(usuario.Sueldo).ToString();
        }
        private void MostrarBotones(bool mostrar)
        {
            btnInvertirAmazon.Visible = mostrar;
            btnInvertirApple.Visible = mostrar;
            btnInvertirTesla.Visible = mostrar;
            btnInvertirMicrosoft.Visible = mostrar;
            pictureBoxVolver.Visible = mostrar;

        }
    }
}
