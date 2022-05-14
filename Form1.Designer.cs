
namespace FaceDetection
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cameraInput = new Emgu.CV.UI.PanAndZoomPictureBox();
            this.start = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cameraInput)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraInput
            // 
            this.cameraInput.Location = new System.Drawing.Point(12, 12);
            this.cameraInput.Name = "cameraInput";
            this.cameraInput.Size = new System.Drawing.Size(379, 334);
            this.cameraInput.TabIndex = 1;
            this.cameraInput.TabStop = false;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(506, 60);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(126, 23);
            this.start.TabIndex = 2;
            this.start.Text = "Détecter";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Capture Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(506, 141);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(127, 20);
            this.nom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.cameraInput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cameraInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.PanAndZoomPictureBox cameraInput;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label1;
    }
}

