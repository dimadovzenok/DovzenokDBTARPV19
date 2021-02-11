using System;
using System.Windows.Forms;

namespace DovzenokTAR
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Parents_Cbox = new System.Windows.Forms.CheckBox();
            this.Form_Send = new System.Windows.Forms.Panel();
            this.BTN_send = new System.Windows.Forms.Button();
            this.BTN_file = new System.Windows.Forms.Button();
            this.TXT_file = new System.Windows.Forms.TextBox();
            this.TXT_from = new System.Windows.Forms.TextBox();
            this.LBL_from = new System.Windows.Forms.Label();
            this.TXT_msgbody = new System.Windows.Forms.TextBox();
            this.TXT_to = new System.Windows.Forms.TextBox();
            this.LBL_to = new System.Windows.Forms.Label();
            this.TXT_subject = new System.Windows.Forms.TextBox();
            this.LBL_subject = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.Form_Edit = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.AgeEditBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GroupEditBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameEditBox = new System.Windows.Forms.TextBox();
            this.NumberEditBox = new System.Windows.Forms.TextBox();
            this.EmailEditBox = new System.Windows.Forms.TextBox();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Form_Add = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Form_Send.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.Form_Edit.SuspendLayout();
            this.Form_Add.SuspendLayout();
            this.SuspendLayout();
            // 
            // Parents_Cbox
            // 
            this.Parents_Cbox.AutoSize = true;
            this.Parents_Cbox.BackColor = System.Drawing.Color.Transparent;
            this.Parents_Cbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Parents_Cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Parents_Cbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Parents_Cbox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Parents_Cbox.Location = new System.Drawing.Point(184, 200);
            this.Parents_Cbox.Name = "Parents_Cbox";
            this.Parents_Cbox.Size = new System.Drawing.Size(95, 22);
            this.Parents_Cbox.TabIndex = 8;
            this.Parents_Cbox.Text = "Родители";
            this.Parents_Cbox.UseVisualStyleBackColor = false;
            this.Parents_Cbox.CheckedChanged += new System.EventHandler(this.Parents_Cbox_CheckedChanged_1);
            // 
            // Form_Send
            // 
            this.Form_Send.BackColor = System.Drawing.Color.Silver;
            this.Form_Send.Controls.Add(this.BTN_send);
            this.Form_Send.Controls.Add(this.BTN_file);
            this.Form_Send.Controls.Add(this.TXT_file);
            this.Form_Send.Controls.Add(this.TXT_from);
            this.Form_Send.Controls.Add(this.LBL_from);
            this.Form_Send.Controls.Add(this.TXT_msgbody);
            this.Form_Send.Controls.Add(this.TXT_to);
            this.Form_Send.Controls.Add(this.LBL_to);
            this.Form_Send.Controls.Add(this.TXT_subject);
            this.Form_Send.Controls.Add(this.LBL_subject);
            this.Form_Send.Location = new System.Drawing.Point(184, 236);
            this.Form_Send.Name = "Form_Send";
            this.Form_Send.Size = new System.Drawing.Size(646, 263);
            this.Form_Send.TabIndex = 7;
            // 
            // BTN_send
            // 
            this.BTN_send.BackColor = System.Drawing.Color.White;
            this.BTN_send.FlatAppearance.BorderSize = 0;
            this.BTN_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_send.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.BTN_send.ForeColor = System.Drawing.Color.Black;
            this.BTN_send.Location = new System.Drawing.Point(14, 221);
            this.BTN_send.Name = "BTN_send";
            this.BTN_send.Size = new System.Drawing.Size(180, 32);
            this.BTN_send.TabIndex = 44;
            this.BTN_send.Text = "Отправить письмо";
            this.BTN_send.UseVisualStyleBackColor = false;
            this.BTN_send.Click += new System.EventHandler(this.BTN_send_Click);
            // 
            // BTN_file
            // 
            this.BTN_file.BackColor = System.Drawing.Color.White;
            this.BTN_file.FlatAppearance.BorderSize = 0;
            this.BTN_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_file.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.BTN_file.ForeColor = System.Drawing.Color.Black;
            this.BTN_file.Location = new System.Drawing.Point(14, 134);
            this.BTN_file.Name = "BTN_file";
            this.BTN_file.Size = new System.Drawing.Size(153, 29);
            this.BTN_file.TabIndex = 43;
            this.BTN_file.Text = "Добавить файл";
            this.BTN_file.UseVisualStyleBackColor = false;
            this.BTN_file.Click += new System.EventHandler(this.BTN_file_Click_1);
            // 
            // TXT_file
            // 
            this.TXT_file.BackColor = System.Drawing.Color.White;
            this.TXT_file.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_file.Font = new System.Drawing.Font("Calibri", 12F);
            this.TXT_file.Location = new System.Drawing.Point(14, 169);
            this.TXT_file.Multiline = true;
            this.TXT_file.Name = "TXT_file";
            this.TXT_file.Size = new System.Drawing.Size(291, 21);
            this.TXT_file.TabIndex = 42;
            // 
            // TXT_from
            // 
            this.TXT_from.BackColor = System.Drawing.Color.White;
            this.TXT_from.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_from.Font = new System.Drawing.Font("Calibri", 12F);
            this.TXT_from.Location = new System.Drawing.Point(80, 13);
            this.TXT_from.Multiline = true;
            this.TXT_from.Name = "TXT_from";
            this.TXT_from.Size = new System.Drawing.Size(225, 21);
            this.TXT_from.TabIndex = 40;
            // 
            // LBL_from
            // 
            this.LBL_from.AutoSize = true;
            this.LBL_from.BackColor = System.Drawing.Color.Silver;
            this.LBL_from.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_from.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_from.Location = new System.Drawing.Point(28, 11);
            this.LBL_from.Name = "LBL_from";
            this.LBL_from.Size = new System.Drawing.Size(30, 23);
            this.LBL_from.TabIndex = 41;
            this.LBL_from.Text = "От";
            // 
            // TXT_msgbody
            // 
            this.TXT_msgbody.BackColor = System.Drawing.Color.White;
            this.TXT_msgbody.Font = new System.Drawing.Font("Calibri", 12F);
            this.TXT_msgbody.Location = new System.Drawing.Point(311, 8);
            this.TXT_msgbody.Multiline = true;
            this.TXT_msgbody.Name = "TXT_msgbody";
            this.TXT_msgbody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TXT_msgbody.Size = new System.Drawing.Size(313, 244);
            this.TXT_msgbody.TabIndex = 39;
            // 
            // TXT_to
            // 
            this.TXT_to.BackColor = System.Drawing.Color.White;
            this.TXT_to.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_to.Font = new System.Drawing.Font("Calibri", 12F);
            this.TXT_to.Location = new System.Drawing.Point(80, 49);
            this.TXT_to.Multiline = true;
            this.TXT_to.Name = "TXT_to";
            this.TXT_to.Size = new System.Drawing.Size(225, 21);
            this.TXT_to.TabIndex = 35;
            // 
            // LBL_to
            // 
            this.LBL_to.AutoSize = true;
            this.LBL_to.BackColor = System.Drawing.Color.Silver;
            this.LBL_to.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_to.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_to.Location = new System.Drawing.Point(28, 46);
            this.LBL_to.Name = "LBL_to";
            this.LBL_to.Size = new System.Drawing.Size(54, 23);
            this.LBL_to.TabIndex = 36;
            this.LBL_to.Text = "Кому";
            // 
            // TXT_subject
            // 
            this.TXT_subject.BackColor = System.Drawing.Color.White;
            this.TXT_subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_subject.Font = new System.Drawing.Font("Calibri", 12F);
            this.TXT_subject.Location = new System.Drawing.Point(80, 89);
            this.TXT_subject.Multiline = true;
            this.TXT_subject.Name = "TXT_subject";
            this.TXT_subject.Size = new System.Drawing.Size(225, 21);
            this.TXT_subject.TabIndex = 33;
            // 
            // LBL_subject
            // 
            this.LBL_subject.AutoSize = true;
            this.LBL_subject.BackColor = System.Drawing.Color.Silver;
            this.LBL_subject.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_subject.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBL_subject.Location = new System.Drawing.Point(15, 87);
            this.LBL_subject.Name = "LBL_subject";
            this.LBL_subject.Size = new System.Drawing.Size(50, 23);
            this.LBL_subject.TabIndex = 34;
            this.LBL_subject.Text = "Тема";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(181, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(658, 175);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Exit_Button);
            this.panel1.Controls.Add(this.SendMessageButton);
            this.panel1.Controls.Add(this.Remove_Button);
            this.panel1.Controls.Add(this.Form_Edit);
            this.panel1.Controls.Add(this.Edit_button);
            this.panel1.Controls.Add(this.Form_Add);
            this.panel1.Controls.Add(this.Add_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 513);
            this.panel1.TabIndex = 5;
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.White;
            this.Exit_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.Exit_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit_Button.Location = new System.Drawing.Point(0, 730);
            this.Exit_Button.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(161, 36);
            this.Exit_Button.TabIndex = 8;
            this.Exit_Button.Text = "Выход";
            this.Exit_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click_1);
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.BackColor = System.Drawing.Color.White;
            this.SendMessageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SendMessageButton.FlatAppearance.BorderSize = 0;
            this.SendMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMessageButton.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.SendMessageButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SendMessageButton.Location = new System.Drawing.Point(0, 694);
            this.SendMessageButton.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(161, 36);
            this.SendMessageButton.TabIndex = 7;
            this.SendMessageButton.Text = "Отправить письмо";
            this.SendMessageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SendMessageButton.UseVisualStyleBackColor = false;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click_1);
            // 
            // Remove_Button
            // 
            this.Remove_Button.BackColor = System.Drawing.Color.White;
            this.Remove_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Remove_Button.FlatAppearance.BorderSize = 0;
            this.Remove_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_Button.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.Remove_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Remove_Button.Location = new System.Drawing.Point(0, 658);
            this.Remove_Button.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(161, 36);
            this.Remove_Button.TabIndex = 3;
            this.Remove_Button.Text = "Удалить";
            this.Remove_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Remove_Button.UseVisualStyleBackColor = false;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click_1);
            // 
            // Form_Edit
            // 
            this.Form_Edit.BackColor = System.Drawing.Color.Transparent;
            this.Form_Edit.Controls.Add(this.label10);
            this.Form_Edit.Controls.Add(this.AgeEditBox);
            this.Form_Edit.Controls.Add(this.label7);
            this.Form_Edit.Controls.Add(this.GroupEditBox);
            this.Form_Edit.Controls.Add(this.button1);
            this.Form_Edit.Controls.Add(this.label4);
            this.Form_Edit.Controls.Add(this.label6);
            this.Form_Edit.Controls.Add(this.label5);
            this.Form_Edit.Controls.Add(this.NameEditBox);
            this.Form_Edit.Controls.Add(this.NumberEditBox);
            this.Form_Edit.Controls.Add(this.EmailEditBox);
            this.Form_Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form_Edit.Location = new System.Drawing.Point(0, 365);
            this.Form_Edit.Name = "Form_Edit";
            this.Form_Edit.Size = new System.Drawing.Size(161, 293);
            this.Form_Edit.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(8, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Возвраст";
            // 
            // AgeEditBox
            // 
            this.AgeEditBox.Location = new System.Drawing.Point(8, 174);
            this.AgeEditBox.Name = "AgeEditBox";
            this.AgeEditBox.Size = new System.Drawing.Size(137, 20);
            this.AgeEditBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(8, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Группа";
            // 
            // GroupEditBox
            // 
            this.GroupEditBox.Location = new System.Drawing.Point(8, 221);
            this.GroupEditBox.Name = "GroupEditBox";
            this.GroupEditBox.Size = new System.Drawing.Size(137, 20);
            this.GroupEditBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(8, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(8, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(8, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(8, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Телефон";
            // 
            // NameEditBox
            // 
            this.NameEditBox.Location = new System.Drawing.Point(8, 37);
            this.NameEditBox.Name = "NameEditBox";
            this.NameEditBox.Size = new System.Drawing.Size(137, 20);
            this.NameEditBox.TabIndex = 10;
            // 
            // NumberEditBox
            // 
            this.NumberEditBox.Location = new System.Drawing.Point(8, 84);
            this.NumberEditBox.Name = "NumberEditBox";
            this.NumberEditBox.Size = new System.Drawing.Size(137, 20);
            this.NumberEditBox.TabIndex = 11;
            // 
            // EmailEditBox
            // 
            this.EmailEditBox.Location = new System.Drawing.Point(8, 131);
            this.EmailEditBox.Name = "EmailEditBox";
            this.EmailEditBox.Size = new System.Drawing.Size(137, 20);
            this.EmailEditBox.TabIndex = 12;
            // 
            // Edit_button
            // 
            this.Edit_button.BackColor = System.Drawing.Color.White;
            this.Edit_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Edit_button.FlatAppearance.BorderSize = 0;
            this.Edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_button.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.Edit_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Edit_button.Location = new System.Drawing.Point(0, 329);
            this.Edit_button.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(161, 36);
            this.Edit_button.TabIndex = 4;
            this.Edit_button.Text = "Редактировать";
            this.Edit_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit_button.UseVisualStyleBackColor = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Form_Add
            // 
            this.Form_Add.BackColor = System.Drawing.Color.White;
            this.Form_Add.Controls.Add(this.label9);
            this.Form_Add.Controls.Add(this.GroupBox);
            this.Form_Add.Controls.Add(this.label8);
            this.Form_Add.Controls.Add(this.AgeBox);
            this.Form_Add.Controls.Add(this.Submit_Button);
            this.Form_Add.Controls.Add(this.label3);
            this.Form_Add.Controls.Add(this.label2);
            this.Form_Add.Controls.Add(this.label1);
            this.Form_Add.Controls.Add(this.EmailBox);
            this.Form_Add.Controls.Add(this.NumberBox);
            this.Form_Add.Controls.Add(this.NameBox);
            this.Form_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form_Add.Location = new System.Drawing.Point(0, 36);
            this.Form_Add.Name = "Form_Add";
            this.Form_Add.Size = new System.Drawing.Size(161, 293);
            this.Form_Add.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(12, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Группа";
            // 
            // GroupBox
            // 
            this.GroupBox.Location = new System.Drawing.Point(12, 220);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(137, 20);
            this.GroupBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(12, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Возвраст";
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(12, 173);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(137, 20);
            this.AgeBox.TabIndex = 10;
            // 
            // Submit_Button
            // 
            this.Submit_Button.BackColor = System.Drawing.Color.White;
            this.Submit_Button.FlatAppearance.BorderSize = 0;
            this.Submit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_Button.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.Submit_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Submit_Button.Location = new System.Drawing.Point(12, 246);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(137, 39);
            this.Submit_Button.TabIndex = 6;
            this.Submit_Button.Text = "Добавить";
            this.Submit_Button.UseVisualStyleBackColor = false;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Телефон";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(12, 126);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(137, 20);
            this.EmailBox.TabIndex = 6;
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(12, 79);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(137, 20);
            this.NumberBox.TabIndex = 4;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(12, 32);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(137, 20);
            this.NameBox.TabIndex = 0;
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.White;
            this.Add_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Add_Button.FlatAppearance.BorderSize = 0;
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Button.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add_Button.Location = new System.Drawing.Point(0, 0);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(161, 36);
            this.Add_Button.TabIndex = 0;
            this.Add_Button.Text = "Добавить";
            this.Add_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(850, 513);
            this.Controls.Add(this.Parents_Cbox);
            this.Controls.Add(this.Form_Send);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Form_Send.ResumeLayout(false);
            this.Form_Send.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Form_Edit.ResumeLayout(false);
            this.Form_Edit.PerformLayout();
            this.Form_Add.ResumeLayout(false);
            this.Form_Add.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.CheckBox Parents_Cbox;
        private System.Windows.Forms.Panel Form_Send;
        private System.Windows.Forms.Button BTN_send;
        private System.Windows.Forms.Button BTN_file;
        private System.Windows.Forms.TextBox TXT_file;
        private System.Windows.Forms.TextBox TXT_from;
        private System.Windows.Forms.Label LBL_from;
        private System.Windows.Forms.TextBox TXT_msgbody;
        private System.Windows.Forms.TextBox TXT_to;
        private System.Windows.Forms.Label LBL_to;
        private System.Windows.Forms.TextBox TXT_subject;
        private System.Windows.Forms.Label LBL_subject;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.Panel Form_Edit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AgeEditBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GroupEditBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameEditBox;
        private System.Windows.Forms.TextBox NumberEditBox;
        private System.Windows.Forms.TextBox EmailEditBox;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Panel Form_Add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox GroupBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button Add_Button;
    }
}

