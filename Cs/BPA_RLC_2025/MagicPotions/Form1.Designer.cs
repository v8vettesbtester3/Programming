namespace MagicPotions
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddPotion = new Button();
            btnRemovePotion = new Button();
            btnDisplayPotions = new Button();
            btnMysteryMix = new Button();
            btnSearchPotion = new Button();
            btnExperimentPotion = new Button();
            lblPotionNameInput = new Label();
            lblIngredientsInput = new Label();
            lblEffectInput = new Label();
            lblPotencyInput = new Label();
            lblPotionDisplayList = new Label();
            lblStatusMessage = new Label();
            txtPotionNameInput = new TextBox();
            txtIngredientsInput = new TextBox();
            txtEffectInput = new TextBox();
            txtPotencyInput = new TextBox();
            lstPotionDisplayList = new ListBox();
            SuspendLayout();
            // 
            // btnAddPotion
            // 
            btnAddPotion.Location = new Point(512, 32);
            btnAddPotion.Name = "btnAddPotion";
            btnAddPotion.Size = new Size(120, 35);
            btnAddPotion.TabIndex = 0;
            btnAddPotion.Text = "Add Potion";
            btnAddPotion.UseVisualStyleBackColor = true;
            btnAddPotion.Click += btnAddPotion_Click;
            // 
            // btnRemovePotion
            // 
            btnRemovePotion.Location = new Point(656, 32);
            btnRemovePotion.Name = "btnRemovePotion";
            btnRemovePotion.Size = new Size(120, 35);
            btnRemovePotion.TabIndex = 1;
            btnRemovePotion.Text = "Remove Potion";
            btnRemovePotion.UseVisualStyleBackColor = true;
            btnRemovePotion.Click += btnRemovePotion_Click;
            // 
            // btnDisplayPotions
            // 
            btnDisplayPotions.Location = new Point(512, 96);
            btnDisplayPotions.Name = "btnDisplayPotions";
            btnDisplayPotions.Size = new Size(120, 35);
            btnDisplayPotions.TabIndex = 2;
            btnDisplayPotions.Text = "Display Potions";
            btnDisplayPotions.UseVisualStyleBackColor = true;
            btnDisplayPotions.Click += btnDisplayPotions_Click;
            // 
            // btnMysteryMix
            // 
            btnMysteryMix.Location = new Point(656, 96);
            btnMysteryMix.Name = "btnMysteryMix";
            btnMysteryMix.Size = new Size(120, 35);
            btnMysteryMix.TabIndex = 3;
            btnMysteryMix.Text = "Mystery Mix";
            btnMysteryMix.UseVisualStyleBackColor = true;
            btnMysteryMix.Click += btnMysteryMix_Click;
            // 
            // btnSearchPotion
            // 
            btnSearchPotion.Location = new Point(512, 160);
            btnSearchPotion.Name = "btnSearchPotion";
            btnSearchPotion.Size = new Size(120, 35);
            btnSearchPotion.TabIndex = 4;
            btnSearchPotion.Text = "Search Potion";
            btnSearchPotion.UseVisualStyleBackColor = true;
            btnSearchPotion.Click += btnSearchPotion_Click;
            // 
            // btnExperimentPotion
            // 
            btnExperimentPotion.Location = new Point(656, 160);
            btnExperimentPotion.Name = "btnExperimentPotion";
            btnExperimentPotion.Size = new Size(120, 35);
            btnExperimentPotion.TabIndex = 5;
            btnExperimentPotion.Text = "Experiment Potion";
            btnExperimentPotion.UseVisualStyleBackColor = true;
            btnExperimentPotion.Click += btnExperimentPotion_Click;
            // 
            // lblPotionNameInput
            // 
            lblPotionNameInput.AutoSize = true;
            lblPotionNameInput.Location = new Point(40, 40);
            lblPotionNameInput.Name = "lblPotionNameInput";
            lblPotionNameInput.Size = new Size(108, 15);
            lblPotionNameInput.TabIndex = 6;
            lblPotionNameInput.Text = "Potion Name Input";
            // 
            // lblIngredientsInput
            // 
            lblIngredientsInput.AutoSize = true;
            lblIngredientsInput.Location = new Point(40, 88);
            lblIngredientsInput.Name = "lblIngredientsInput";
            lblIngredientsInput.Size = new Size(203, 15);
            lblIngredientsInput.TabIndex = 7;
            lblIngredientsInput.Text = "Ingredients Input (comma separated)";
            // 
            // lblEffectInput
            // 
            lblEffectInput.AutoSize = true;
            lblEffectInput.Location = new Point(40, 136);
            lblEffectInput.Name = "lblEffectInput";
            lblEffectInput.Size = new Size(68, 15);
            lblEffectInput.TabIndex = 8;
            lblEffectInput.Text = "Effect Input";
            // 
            // lblPotencyInput
            // 
            lblPotencyInput.AutoSize = true;
            lblPotencyInput.Location = new Point(40, 184);
            lblPotencyInput.Name = "lblPotencyInput";
            lblPotencyInput.Size = new Size(81, 15);
            lblPotencyInput.TabIndex = 9;
            lblPotencyInput.Text = "Potency Input";
            // 
            // lblPotionDisplayList
            // 
            lblPotionDisplayList.AutoSize = true;
            lblPotionDisplayList.Location = new Point(40, 240);
            lblPotionDisplayList.Name = "lblPotionDisplayList";
            lblPotionDisplayList.Size = new Size(104, 15);
            lblPotionDisplayList.TabIndex = 10;
            lblPotionDisplayList.Text = "Potion Display List";
            // 
            // lblStatusMessage
            // 
            lblStatusMessage.AutoSize = true;
            lblStatusMessage.Location = new Point(40, 480);
            lblStatusMessage.Name = "lblStatusMessage";
            lblStatusMessage.Size = new Size(88, 15);
            lblStatusMessage.TabIndex = 11;
            lblStatusMessage.Text = "Status Message";
            // 
            // txtPotionNameInput
            // 
            txtPotionNameInput.Location = new Point(256, 40);
            txtPotionNameInput.Name = "txtPotionNameInput";
            txtPotionNameInput.Size = new Size(180, 23);
            txtPotionNameInput.TabIndex = 12;
            // 
            // txtIngredientsInput
            // 
            txtIngredientsInput.Location = new Point(256, 88);
            txtIngredientsInput.Name = "txtIngredientsInput";
            txtIngredientsInput.Size = new Size(180, 23);
            txtIngredientsInput.TabIndex = 13;
            // 
            // txtEffectInput
            // 
            txtEffectInput.Location = new Point(256, 136);
            txtEffectInput.Name = "txtEffectInput";
            txtEffectInput.Size = new Size(180, 23);
            txtEffectInput.TabIndex = 14;
            // 
            // txtPotencyInput
            // 
            txtPotencyInput.Location = new Point(256, 184);
            txtPotencyInput.Name = "txtPotencyInput";
            txtPotencyInput.Size = new Size(180, 23);
            txtPotencyInput.TabIndex = 15;
            // 
            // lstPotionDisplayList
            // 
            lstPotionDisplayList.FormattingEnabled = true;
            lstPotionDisplayList.ItemHeight = 15;
            lstPotionDisplayList.Location = new Point(40, 264);
            lstPotionDisplayList.Name = "lstPotionDisplayList";
            lstPotionDisplayList.Size = new Size(736, 199);
            lstPotionDisplayList.TabIndex = 16;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(lstPotionDisplayList);
            Controls.Add(txtPotencyInput);
            Controls.Add(txtEffectInput);
            Controls.Add(txtIngredientsInput);
            Controls.Add(txtPotionNameInput);
            Controls.Add(lblStatusMessage);
            Controls.Add(lblPotionDisplayList);
            Controls.Add(lblPotencyInput);
            Controls.Add(lblEffectInput);
            Controls.Add(lblIngredientsInput);
            Controls.Add(lblPotionNameInput);
            Controls.Add(btnExperimentPotion);
            Controls.Add(btnSearchPotion);
            Controls.Add(btnMysteryMix);
            Controls.Add(btnDisplayPotions);
            Controls.Add(btnRemovePotion);
            Controls.Add(btnAddPotion);
            Name = "MainForm";
            Text = "MagicPotions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddPotion;
        private Button btnRemovePotion;
        private Button btnDisplayPotions;
        private Button btnMysteryMix;
        private Button btnSearchPotion;
        private Button btnExperimentPotion;
        private Label lblPotionNameInput;
        private Label lblIngredientsInput;
        private Label lblEffectInput;
        private Label lblPotencyInput;
        private Label lblPotionDisplayList;
        private Label lblStatusMessage;
        private TextBox txtPotionNameInput;
        private TextBox txtIngredientsInput;
        private TextBox txtEffectInput;
        private TextBox txtPotencyInput;
        private ListBox lstPotionDisplayList;
    }
}
