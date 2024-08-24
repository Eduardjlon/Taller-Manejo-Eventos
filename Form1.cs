using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp1.Clases;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Tarea> tareas = new List<Tarea>();

        public Form1()
        {
            InitializeComponent();

            TextTarea.KeyDown += TextTarea_KeyDown;

            BoxEstadosTarea.Items.Add("Tareas sin empezar");
            BoxEstadosTarea.Items.Add("Tareas en Progreso");
            BoxEstadosTarea.Items.Add("Tareas Completadas");
            BoxEstadosTarea.SelectedIndex = 0;
        }

        private void TextTarea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AgregarTarea();
            }
        }

        private void AgregarTarea()
        {
            if (TextTarea.Text.Trim() == "")
            {
                MessageBox.Show("Verifica el nombre de la tarea");
                return;
            }

            string estadoSeleccionado = BoxEstadosTarea.SelectedItem.ToString();
            Tarea nuevaTarea = new Tarea(TextTarea.Text, estadoSeleccionado);
            tareas.Add(nuevaTarea);

            TextTarea.Text = "";

            RenderizarTareas();
        }

        private void RenderizarTareas()
        {
            PanelTareasP.Controls.Clear();
            PanelTareasProgreso.Controls.Clear();
            PanelTareasComplet.Controls.Clear();

            foreach (Tarea tarea in tareas)
            {
                Label tarjeta = new Label();
                tarjeta.Text = tarea.Nombre;
                tarjeta.AutoSize = true;
                tarjeta.Padding = new Padding(5);
                tarjeta.Margin = new Padding(2);
                tarjeta.BorderStyle = BorderStyle.FixedSingle;

                if (tarea.Estado == "Tareas sin empezar")
                {
                    tarjeta.BackColor = Color.Red;
                }
                else if (tarea.Estado == "Tareas en Progreso")
                {
                    tarjeta.BackColor = Color.Orange;
                }
                else if (tarea.Estado == "Tareas Completadas")
                {
                    tarjeta.BackColor = Color.LightGreen;
                }

                tarjeta.DoubleClick += (sender, e) =>
                {
                    if (tarea.Estado == "Tareas sin empezar")
                    {
                        tarea.Estado = "Tareas en Progreso";
                    }
                    else if (tarea.Estado == "Tareas en Progreso")
                    {
                        tarea.Estado = "Tareas Completadas";
                    }
                    else if (tarea.Estado == "Tareas Completadas")
                    {
                        tareas.Remove(tarea);
                    }
                    RenderizarTareas();
                };

                /*Añadimos la tarea al panel correspondiente*/
                if (tarea.Estado == "Tareas sin empezar")
                {
                    PanelTareasP.Controls.Add(tarjeta);
                }
                else if (tarea.Estado == "Tareas en Progreso")
                {
                    PanelTareasProgreso.Controls.Add(tarjeta);
                }
                else if (tarea.Estado == "Tareas Completadas")
                {
                    PanelTareasComplet.Controls.Add(tarjeta);
                }
            }
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            AgregarTarea();
        }

        private void labelCompletadas_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
