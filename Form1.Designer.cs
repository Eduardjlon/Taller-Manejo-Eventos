namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox BoxEstadosTarea;
        private System.Windows.Forms.TextBox TextTarea;
        private System.Windows.Forms.FlowLayoutPanel PanelTareasP;
        private System.Windows.Forms.FlowLayoutPanel PanelTareasProgreso;
        private System.Windows.Forms.FlowLayoutPanel PanelTareasComplet;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            BoxEstadosTarea = new ComboBox();
            TextTarea = new TextBox();
            PanelTareasP = new FlowLayoutPanel();
            PanelTareasProgreso = new FlowLayoutPanel();
            PanelTareasComplet = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // BoxEstadosTarea
            // 
            BoxEstadosTarea.BackColor = SystemColors.WindowText;
            BoxEstadosTarea.Cursor = Cursors.WaitCursor;
            BoxEstadosTarea.DropDownStyle = ComboBoxStyle.DropDownList;
            BoxEstadosTarea.ForeColor = Color.AliceBlue;
            BoxEstadosTarea.FormattingEnabled = true;
            BoxEstadosTarea.Location = new Point(330, 37);
            BoxEstadosTarea.Name = "BoxEstadosTarea";
            BoxEstadosTarea.Size = new Size(150, 23);
            BoxEstadosTarea.TabIndex = 0;
            // 
            // TextTarea
            // 
            TextTarea.BackColor = SystemColors.WindowText;
            TextTarea.ForeColor = SystemColors.Window;
            TextTarea.Location = new Point(12, 37);
            TextTarea.Name = "TextTarea";
            TextTarea.Size = new Size(312, 23);
            TextTarea.TabIndex = 1;
            // 
            // PanelTareasP
            // 
            PanelTareasP.BackColor = Color.Firebrick;
            PanelTareasP.ForeColor = SystemColors.Desktop;
            PanelTareasP.Location = new Point(12, 66);
            PanelTareasP.Name = "PanelTareasP";
            PanelTareasP.Size = new Size(150, 186);
            PanelTareasP.TabIndex = 3;
            // 
            // PanelTareasProgreso
            // 
            PanelTareasProgreso.BackColor = Color.DarkOrange;
            PanelTareasProgreso.ForeColor = SystemColors.Desktop;
            PanelTareasProgreso.Location = new Point(170, 66);
            PanelTareasProgreso.Name = "PanelTareasProgreso";
            PanelTareasProgreso.Size = new Size(150, 186);
            PanelTareasProgreso.TabIndex = 4;
            // 
            // PanelTareasComplet
            // 
            PanelTareasComplet.BackColor = Color.DarkSeaGreen;
            PanelTareasComplet.ForeColor = SystemColors.Desktop;
            PanelTareasComplet.Location = new Point(330, 66);
            PanelTareasComplet.Name = "PanelTareasComplet";
            PanelTareasComplet.Size = new Size(150, 186);
            PanelTareasComplet.TabIndex = 5;
            // 
            // Form1
            // 
            ClientSize = new Size(771, 545);
            Controls.Add(BoxEstadosTarea);
            Controls.Add(TextTarea);
            Controls.Add(PanelTareasP);
            Controls.Add(PanelTareasProgreso);
            Controls.Add(PanelTareasComplet);
            ForeColor = Color.Gainsboro;
            Name = "Form1";
            Text = "Gestión de Tareas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
