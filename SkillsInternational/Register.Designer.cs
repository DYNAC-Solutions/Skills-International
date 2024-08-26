namespace SkillsInternational
{
    partial class Register
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
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.exitLink = new System.Windows.Forms.LinkLabel();
            this.windowTopic = new System.Windows.Forms.Label();
            this.registerGroup = new System.Windows.Forms.GroupBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.registerNumberCombo = new System.Windows.Forms.ComboBox();
            this.registerNumberLabel = new System.Windows.Forms.Label();
            this.parentDetailsGroup = new System.Windows.Forms.GroupBox();
            this.parentContactNumberLabel = new System.Windows.Forms.Label();
            this.parentNICLabel = new System.Windows.Forms.Label();
            this.parentNameLabel = new System.Windows.Forms.Label();
            this.contactInput = new System.Windows.Forms.TextBox();
            this.nicInput = new System.Windows.Forms.TextBox();
            this.parentNameInput = new System.Windows.Forms.TextBox();
            this.contactDetailsGroup = new System.Windows.Forms.GroupBox();
            this.homeInput = new System.Windows.Forms.TextBox();
            this.mobileInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.homePhoneLabel = new System.Windows.Forms.Label();
            this.mobilePhoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.basicDetailsGroup = new System.Windows.Forms.GroupBox();
            this.femalRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.dateofBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registerGroup.SuspendLayout();
            this.parentDetailsGroup.SuspendLayout();
            this.contactDetailsGroup.SuspendLayout();
            this.basicDetailsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutLink
            // 
            this.logoutLink.AutoSize = true;
            this.logoutLink.Location = new System.Drawing.Point(12, 9);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(48, 16);
            this.logoutLink.TabIndex = 0;
            this.logoutLink.TabStop = true;
            this.logoutLink.Text = "Logout";
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLinkClicked);
            // 
            // exitLink
            // 
            this.exitLink.AutoSize = true;
            this.exitLink.Location = new System.Drawing.Point(732, 949);
            this.exitLink.Name = "exitLink";
            this.exitLink.Size = new System.Drawing.Size(28, 16);
            this.exitLink.TabIndex = 0;
            this.exitLink.TabStop = true;
            this.exitLink.Text = "Exit";
            this.exitLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.eixtLinkClicked);
            // 
            // windowTopic
            // 
            this.windowTopic.AutoSize = true;
            this.windowTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowTopic.Location = new System.Drawing.Point(249, 9);
            this.windowTopic.Name = "windowTopic";
            this.windowTopic.Size = new System.Drawing.Size(267, 32);
            this.windowTopic.TabIndex = 1;
            this.windowTopic.Text = "Skills International";
            this.windowTopic.Click += new System.EventHandler(this.label1_Click);
            // 
            // registerGroup
            // 
            this.registerGroup.Controls.Add(this.updateButton);
            this.registerGroup.Controls.Add(this.registerButton);
            this.registerGroup.Controls.Add(this.clearButton);
            this.registerGroup.Controls.Add(this.deleteButton);
            this.registerGroup.Controls.Add(this.registerNumberCombo);
            this.registerGroup.Controls.Add(this.registerNumberLabel);
            this.registerGroup.Controls.Add(this.parentDetailsGroup);
            this.registerGroup.Controls.Add(this.contactDetailsGroup);
            this.registerGroup.Controls.Add(this.basicDetailsGroup);
            this.registerGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.registerGroup.Location = new System.Drawing.Point(29, 44);
            this.registerGroup.Name = "registerGroup";
            this.registerGroup.Size = new System.Drawing.Size(743, 891);
            this.registerGroup.TabIndex = 2;
            this.registerGroup.TabStop = false;
            this.registerGroup.Text = "Student Registration";
            this.registerGroup.Enter += new System.EventHandler(this.registerGroup_Enter);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(104, 831);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 38);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(18, 831);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 38);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(565, 831);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 38);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(656, 831);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 38);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // registerNumberCombo
            // 
            this.registerNumberCombo.FormattingEnabled = true;
            this.registerNumberCombo.Location = new System.Drawing.Point(236, 51);
            this.registerNumberCombo.Name = "registerNumberCombo";
            this.registerNumberCombo.Size = new System.Drawing.Size(121, 25);
            this.registerNumberCombo.TabIndex = 2;
            this.registerNumberCombo.SelectedIndexChanged += new System.EventHandler(this.registerNumberCombo_SelectedIndexChanged);
            // 
            // registerNumberLabel
            // 
            this.registerNumberLabel.AutoSize = true;
            this.registerNumberLabel.Location = new System.Drawing.Point(148, 54);
            this.registerNumberLabel.Name = "registerNumberLabel";
            this.registerNumberLabel.Size = new System.Drawing.Size(63, 18);
            this.registerNumberLabel.TabIndex = 1;
            this.registerNumberLabel.Text = "Reg No.";
            // 
            // parentDetailsGroup
            // 
            this.parentDetailsGroup.Controls.Add(this.parentContactNumberLabel);
            this.parentDetailsGroup.Controls.Add(this.parentNICLabel);
            this.parentDetailsGroup.Controls.Add(this.parentNameLabel);
            this.parentDetailsGroup.Controls.Add(this.contactInput);
            this.parentDetailsGroup.Controls.Add(this.nicInput);
            this.parentDetailsGroup.Controls.Add(this.parentNameInput);
            this.parentDetailsGroup.Location = new System.Drawing.Point(43, 563);
            this.parentDetailsGroup.Name = "parentDetailsGroup";
            this.parentDetailsGroup.Size = new System.Drawing.Size(658, 231);
            this.parentDetailsGroup.TabIndex = 0;
            this.parentDetailsGroup.TabStop = false;
            this.parentDetailsGroup.Text = "Parent Details";
            this.parentDetailsGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // parentContactNumberLabel
            // 
            this.parentContactNumberLabel.AutoSize = true;
            this.parentContactNumberLabel.Location = new System.Drawing.Point(81, 147);
            this.parentContactNumberLabel.Name = "parentContactNumberLabel";
            this.parentContactNumberLabel.Size = new System.Drawing.Size(117, 18);
            this.parentContactNumberLabel.TabIndex = 1;
            this.parentContactNumberLabel.Text = "Contact Number";
            // 
            // parentNICLabel
            // 
            this.parentNICLabel.AutoSize = true;
            this.parentNICLabel.Location = new System.Drawing.Point(81, 101);
            this.parentNICLabel.Name = "parentNICLabel";
            this.parentNICLabel.Size = new System.Drawing.Size(33, 18);
            this.parentNICLabel.TabIndex = 1;
            this.parentNICLabel.Text = "NIC";
            // 
            // parentNameLabel
            // 
            this.parentNameLabel.AutoSize = true;
            this.parentNameLabel.Location = new System.Drawing.Point(81, 62);
            this.parentNameLabel.Name = "parentNameLabel";
            this.parentNameLabel.Size = new System.Drawing.Size(95, 18);
            this.parentNameLabel.TabIndex = 1;
            this.parentNameLabel.Text = "Parent Name";
            // 
            // contactInput
            // 
            this.contactInput.Location = new System.Drawing.Point(214, 144);
            this.contactInput.Name = "contactInput";
            this.contactInput.Size = new System.Drawing.Size(383, 24);
            this.contactInput.TabIndex = 0;
            this.contactInput.TextChanged += new System.EventHandler(this.contactInput_TextChanged);
            // 
            // nicInput
            // 
            this.nicInput.Location = new System.Drawing.Point(214, 95);
            this.nicInput.Name = "nicInput";
            this.nicInput.Size = new System.Drawing.Size(383, 24);
            this.nicInput.TabIndex = 0;
            this.nicInput.TextChanged += new System.EventHandler(this.nicInput_TextChanged);
            // 
            // parentNameInput
            // 
            this.parentNameInput.Location = new System.Drawing.Point(214, 56);
            this.parentNameInput.Name = "parentNameInput";
            this.parentNameInput.Size = new System.Drawing.Size(383, 24);
            this.parentNameInput.TabIndex = 0;
            this.parentNameInput.TextChanged += new System.EventHandler(this.parentNameInput_TextChanged);
            // 
            // contactDetailsGroup
            // 
            this.contactDetailsGroup.Controls.Add(this.homeInput);
            this.contactDetailsGroup.Controls.Add(this.mobileInput);
            this.contactDetailsGroup.Controls.Add(this.emailInput);
            this.contactDetailsGroup.Controls.Add(this.addressInput);
            this.contactDetailsGroup.Controls.Add(this.homePhoneLabel);
            this.contactDetailsGroup.Controls.Add(this.mobilePhoneLabel);
            this.contactDetailsGroup.Controls.Add(this.emailLabel);
            this.contactDetailsGroup.Controls.Add(this.addressLabel);
            this.contactDetailsGroup.Location = new System.Drawing.Point(43, 314);
            this.contactDetailsGroup.Name = "contactDetailsGroup";
            this.contactDetailsGroup.Size = new System.Drawing.Size(658, 215);
            this.contactDetailsGroup.TabIndex = 0;
            this.contactDetailsGroup.TabStop = false;
            this.contactDetailsGroup.Text = "Contact Details";
            this.contactDetailsGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // homeInput
            // 
            this.homeInput.Location = new System.Drawing.Point(463, 161);
            this.homeInput.Name = "homeInput";
            this.homeInput.Size = new System.Drawing.Size(134, 24);
            this.homeInput.TabIndex = 1;
            this.homeInput.TextChanged += new System.EventHandler(this.homeInput_TextChanged);
            // 
            // mobileInput
            // 
            this.mobileInput.Location = new System.Drawing.Point(214, 158);
            this.mobileInput.Name = "mobileInput";
            this.mobileInput.Size = new System.Drawing.Size(134, 24);
            this.mobileInput.TabIndex = 1;
            this.mobileInput.TextChanged += new System.EventHandler(this.mobileInput_TextChanged);
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(214, 114);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(383, 24);
            this.emailInput.TabIndex = 1;
            this.emailInput.TextChanged += new System.EventHandler(this.emailInput_TextChanged);
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(214, 37);
            this.addressInput.Multiline = true;
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(383, 53);
            this.addressInput.TabIndex = 1;
            this.addressInput.TextChanged += new System.EventHandler(this.addressInput_TextChanged);
            // 
            // homePhoneLabel
            // 
            this.homePhoneLabel.AutoSize = true;
            this.homePhoneLabel.Location = new System.Drawing.Point(81, 164);
            this.homePhoneLabel.Name = "homePhoneLabel";
            this.homePhoneLabel.Size = new System.Drawing.Size(96, 18);
            this.homePhoneLabel.TabIndex = 0;
            this.homePhoneLabel.Text = "Home Phone";
            // 
            // mobilePhoneLabel
            // 
            this.mobilePhoneLabel.AutoSize = true;
            this.mobilePhoneLabel.Location = new System.Drawing.Point(358, 161);
            this.mobilePhoneLabel.Name = "mobilePhoneLabel";
            this.mobilePhoneLabel.Size = new System.Drawing.Size(99, 18);
            this.mobilePhoneLabel.TabIndex = 0;
            this.mobilePhoneLabel.Text = "Mobile Phone";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(81, 114);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(45, 18);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(81, 37);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(62, 18);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Address";
            // 
            // basicDetailsGroup
            // 
            this.basicDetailsGroup.Controls.Add(this.femalRadio);
            this.basicDetailsGroup.Controls.Add(this.maleRadio);
            this.basicDetailsGroup.Controls.Add(this.dateofBirthPicker);
            this.basicDetailsGroup.Controls.Add(this.lastNameInput);
            this.basicDetailsGroup.Controls.Add(this.firstNameInput);
            this.basicDetailsGroup.Controls.Add(this.label4);
            this.basicDetailsGroup.Controls.Add(this.label3);
            this.basicDetailsGroup.Controls.Add(this.label2);
            this.basicDetailsGroup.Controls.Add(this.label1);
            this.basicDetailsGroup.Location = new System.Drawing.Point(43, 105);
            this.basicDetailsGroup.Name = "basicDetailsGroup";
            this.basicDetailsGroup.Size = new System.Drawing.Size(658, 190);
            this.basicDetailsGroup.TabIndex = 0;
            this.basicDetailsGroup.TabStop = false;
            this.basicDetailsGroup.Text = "Basic Details";
            this.basicDetailsGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // femalRadio
            // 
            this.femalRadio.AutoSize = true;
            this.femalRadio.Location = new System.Drawing.Point(289, 152);
            this.femalRadio.Name = "femalRadio";
            this.femalRadio.Size = new System.Drawing.Size(78, 22);
            this.femalRadio.TabIndex = 3;
            this.femalRadio.TabStop = true;
            this.femalRadio.Text = "Female";
            this.femalRadio.UseVisualStyleBackColor = true;
            this.femalRadio.CheckedChanged += new System.EventHandler(this.femalRadio_CheckedChanged);
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Location = new System.Drawing.Point(214, 152);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(61, 22);
            this.maleRadio.TabIndex = 3;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            this.maleRadio.CheckedChanged += new System.EventHandler(this.maleRadio_CheckedChanged);
            // 
            // dateofBirthPicker
            // 
            this.dateofBirthPicker.Location = new System.Drawing.Point(214, 112);
            this.dateofBirthPicker.Name = "dateofBirthPicker";
            this.dateofBirthPicker.Size = new System.Drawing.Size(271, 24);
            this.dateofBirthPicker.TabIndex = 2;
            this.dateofBirthPicker.ValueChanged += new System.EventHandler(this.dateofBirthPicker_ValueChanged);
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(214, 72);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(383, 24);
            this.lastNameInput.TabIndex = 1;
            this.lastNameInput.TextChanged += new System.EventHandler(this.lastNameInput_TextChanged);
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(214, 39);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(383, 24);
            this.firstNameInput.TabIndex = 1;
            this.firstNameInput.TextChanged += new System.EventHandler(this.firstNameInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 985);
            this.Controls.Add(this.registerGroup);
            this.Controls.Add(this.windowTopic);
            this.Controls.Add(this.exitLink);
            this.Controls.Add(this.logoutLink);
            this.Name = "Register";
            this.Text = "Student Registration - Skills International";
            this.Load += new System.EventHandler(this.Register_Load);
            this.registerGroup.ResumeLayout(false);
            this.registerGroup.PerformLayout();
            this.parentDetailsGroup.ResumeLayout(false);
            this.parentDetailsGroup.PerformLayout();
            this.contactDetailsGroup.ResumeLayout(false);
            this.contactDetailsGroup.PerformLayout();
            this.basicDetailsGroup.ResumeLayout(false);
            this.basicDetailsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel logoutLink;
        private System.Windows.Forms.LinkLabel exitLink;
        private System.Windows.Forms.Label windowTopic;
        private System.Windows.Forms.GroupBox registerGroup;
        private System.Windows.Forms.GroupBox basicDetailsGroup;
        private System.Windows.Forms.GroupBox parentDetailsGroup;
        private System.Windows.Forms.GroupBox contactDetailsGroup;
        private System.Windows.Forms.ComboBox registerNumberCombo;
        private System.Windows.Forms.Label registerNumberLabel;
        private System.Windows.Forms.DateTimePicker dateofBirthPicker;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton femalRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.TextBox contactInput;
        private System.Windows.Forms.TextBox nicInput;
        private System.Windows.Forms.TextBox parentNameInput;
        private System.Windows.Forms.TextBox homeInput;
        private System.Windows.Forms.TextBox mobileInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label homePhoneLabel;
        private System.Windows.Forms.Label mobilePhoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label parentContactNumberLabel;
        private System.Windows.Forms.Label parentNICLabel;
        private System.Windows.Forms.Label parentNameLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button registerButton;
    }
}