namespace Lift
{
    partial class backGround
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
            this.components = new System.ComponentModel.Container();
            this.timerLiftUp = new System.Windows.Forms.Timer(this.components);
            this.timerLiftDown = new System.Windows.Forms.Timer(this.components);
            this.timerLiftUpDoorsOpen = new System.Windows.Forms.Timer(this.components);
            this.timerLiftUpDoorsClosed = new System.Windows.Forms.Timer(this.components);
            this.timerLiftDownDoorsOpen = new System.Windows.Forms.Timer(this.components);
            this.timerLiftDownDoorsClosed = new System.Windows.Forms.Timer(this.components);
            this.dataBaseListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.requestButtonDown = new System.Windows.Forms.PictureBox();
            this.requestButtonUp = new System.Windows.Forms.PictureBox();
            this.clearListBox = new System.Windows.Forms.PictureBox();
            this.insideLift = new System.Windows.Forms.PictureBox();
            this.rightSideDoorUpFloor = new System.Windows.Forms.PictureBox();
            this.leftSideDoorUpFloor = new System.Windows.Forms.PictureBox();
            this.rightSideDoorsGroundFloor = new System.Windows.Forms.PictureBox();
            this.leftSideDoorsGroundFloor = new System.Windows.Forms.PictureBox();
            this.buttonDown = new System.Windows.Forms.PictureBox();
            this.buttonUp = new System.Windows.Forms.PictureBox();
            this.liftGroundFloor = new System.Windows.Forms.PictureBox();
            this.liftFirstFloor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestButtonDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestButtonUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insideLift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSideDoorUpFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSideDoorUpFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSideDoorsGroundFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSideDoorsGroundFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftGroundFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftFirstFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // timerLiftUp
            // 
            this.timerLiftUp.Interval = 10;
            this.timerLiftUp.Tick += new System.EventHandler(this.timerLiftUp_Tick);
            // 
            // timerLiftDown
            // 
            this.timerLiftDown.Interval = 10;
            this.timerLiftDown.Tick += new System.EventHandler(this.timerLiftDown_Tick_1);
            // 
            // timerLiftUpDoorsOpen
            // 
            this.timerLiftUpDoorsOpen.Interval = 10;
            this.timerLiftUpDoorsOpen.Tick += new System.EventHandler(this.timerLiftUpDoorsOpen_Tick);
            // 
            // timerLiftUpDoorsClosed
            // 
            this.timerLiftUpDoorsClosed.Interval = 10;
            this.timerLiftUpDoorsClosed.Tick += new System.EventHandler(this.timerLiftUpDoorsClosed_Tick);
            // 
            // timerLiftDownDoorsOpen
            // 
            this.timerLiftDownDoorsOpen.Interval = 10;
            this.timerLiftDownDoorsOpen.Tick += new System.EventHandler(this.timerLiftDownDoorsOpen_Tick);
            // 
            // timerLiftDownDoorsClosed
            // 
            this.timerLiftDownDoorsClosed.Interval = 10;
            this.timerLiftDownDoorsClosed.Tick += new System.EventHandler(this.timerLiftDownDoorsClosed_Tick);
            // 
            // dataBaseListBox
            // 
            this.dataBaseListBox.BackColor = System.Drawing.Color.Plum;
            this.dataBaseListBox.FormattingEnabled = true;
            this.dataBaseListBox.Location = new System.Drawing.Point(331, 12);
            this.dataBaseListBox.Name = "dataBaseListBox";
            this.dataBaseListBox.Size = new System.Drawing.Size(325, 108);
            this.dataBaseListBox.TabIndex = 9;
            this.dataBaseListBox.SelectedIndexChanged += new System.EventHandler(this.dataBaseListBox_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Image = global::Lift.Properties.Resources.Exit_button1;
            this.exitButton.Location = new System.Drawing.Point(573, 471);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(83, 55);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 13;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // requestButtonDown
            // 
            this.requestButtonDown.Image = global::Lift.Properties.Resources.red_button;
            this.requestButtonDown.Location = new System.Drawing.Point(247, 400);
            this.requestButtonDown.Name = "requestButtonDown";
            this.requestButtonDown.Size = new System.Drawing.Size(26, 23);
            this.requestButtonDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.requestButtonDown.TabIndex = 12;
            this.requestButtonDown.TabStop = false;
            this.requestButtonDown.Click += new System.EventHandler(this.requestButtonDown_Click);
            // 
            // requestButtonUp
            // 
            this.requestButtonUp.Image = global::Lift.Properties.Resources.red_button;
            this.requestButtonUp.Location = new System.Drawing.Point(247, 132);
            this.requestButtonUp.Name = "requestButtonUp";
            this.requestButtonUp.Size = new System.Drawing.Size(26, 23);
            this.requestButtonUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.requestButtonUp.TabIndex = 11;
            this.requestButtonUp.TabStop = false;
            this.requestButtonUp.Click += new System.EventHandler(this.requestButtonUp_Click);
            // 
            // clearListBox
            // 
            this.clearListBox.Image = global::Lift.Properties.Resources.New_Project;
            this.clearListBox.Location = new System.Drawing.Point(331, 154);
            this.clearListBox.Name = "clearListBox";
            this.clearListBox.Size = new System.Drawing.Size(167, 50);
            this.clearListBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clearListBox.TabIndex = 10;
            this.clearListBox.TabStop = false;
            this.clearListBox.Click += new System.EventHandler(this.clearListBox_Click);
            // 
            // insideLift
            // 
            this.insideLift.Image = global::Lift.Properties.Resources.Inside_Lift;
            this.insideLift.Location = new System.Drawing.Point(115, 65);
            this.insideLift.Name = "insideLift";
            this.insideLift.Size = new System.Drawing.Size(98, 155);
            this.insideLift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.insideLift.TabIndex = 8;
            this.insideLift.TabStop = false;
            // 
            // rightSideDoorUpFloor
            // 
            this.rightSideDoorUpFloor.Image = global::Lift.Properties.Resources.rightSideDoors;
            this.rightSideDoorUpFloor.Location = new System.Drawing.Point(163, 65);
            this.rightSideDoorUpFloor.Name = "rightSideDoorUpFloor";
            this.rightSideDoorUpFloor.Size = new System.Drawing.Size(50, 155);
            this.rightSideDoorUpFloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightSideDoorUpFloor.TabIndex = 7;
            this.rightSideDoorUpFloor.TabStop = false;
            // 
            // leftSideDoorUpFloor
            // 
            this.leftSideDoorUpFloor.Image = global::Lift.Properties.Resources.leftSideOfDoors;
            this.leftSideDoorUpFloor.Location = new System.Drawing.Point(115, 65);
            this.leftSideDoorUpFloor.Name = "leftSideDoorUpFloor";
            this.leftSideDoorUpFloor.Size = new System.Drawing.Size(52, 155);
            this.leftSideDoorUpFloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftSideDoorUpFloor.TabIndex = 6;
            this.leftSideDoorUpFloor.TabStop = false;
            // 
            // rightSideDoorsGroundFloor
            // 
            this.rightSideDoorsGroundFloor.Image = global::Lift.Properties.Resources.rightSideDoors;
            this.rightSideDoorsGroundFloor.Location = new System.Drawing.Point(163, 331);
            this.rightSideDoorsGroundFloor.Name = "rightSideDoorsGroundFloor";
            this.rightSideDoorsGroundFloor.Size = new System.Drawing.Size(50, 155);
            this.rightSideDoorsGroundFloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightSideDoorsGroundFloor.TabIndex = 5;
            this.rightSideDoorsGroundFloor.TabStop = false;
            // 
            // leftSideDoorsGroundFloor
            // 
            this.leftSideDoorsGroundFloor.Image = global::Lift.Properties.Resources.leftSideOfDoors;
            this.leftSideDoorsGroundFloor.Location = new System.Drawing.Point(115, 331);
            this.leftSideDoorsGroundFloor.Name = "leftSideDoorsGroundFloor";
            this.leftSideDoorsGroundFloor.Size = new System.Drawing.Size(52, 155);
            this.leftSideDoorsGroundFloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftSideDoorsGroundFloor.TabIndex = 4;
            this.leftSideDoorsGroundFloor.TabStop = false;
            // 
            // buttonDown
            // 
            this.buttonDown.Image = global::Lift.Properties.Resources.downArrow;
            this.buttonDown.Location = new System.Drawing.Point(360, 266);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(100, 50);
            this.buttonDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonDown.TabIndex = 3;
            this.buttonDown.TabStop = false;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Image = global::Lift.Properties.Resources.uparrow;
            this.buttonUp.Location = new System.Drawing.Point(360, 210);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(100, 50);
            this.buttonUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonUp.TabIndex = 2;
            this.buttonUp.TabStop = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // liftGroundFloor
            // 
            this.liftGroundFloor.Image = global::Lift.Properties.Resources.liftWithoutDoors;
            this.liftGroundFloor.Location = new System.Drawing.Point(-1, 266);
            this.liftGroundFloor.Name = "liftGroundFloor";
            this.liftGroundFloor.Size = new System.Drawing.Size(326, 271);
            this.liftGroundFloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.liftGroundFloor.TabIndex = 1;
            this.liftGroundFloor.TabStop = false;
            // 
            // liftFirstFloor
            // 
            this.liftFirstFloor.Image = global::Lift.Properties.Resources.liftWithoutDoors;
            this.liftFirstFloor.Location = new System.Drawing.Point(-1, -1);
            this.liftFirstFloor.Name = "liftFirstFloor";
            this.liftFirstFloor.Size = new System.Drawing.Size(326, 271);
            this.liftFirstFloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.liftFirstFloor.TabIndex = 0;
            this.liftFirstFloor.TabStop = false;
            this.liftFirstFloor.Click += new System.EventHandler(this.liftClosedDoors_Click);
            // 
            // backGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(668, 538);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.requestButtonDown);
            this.Controls.Add(this.requestButtonUp);
            this.Controls.Add(this.clearListBox);
            this.Controls.Add(this.dataBaseListBox);
            this.Controls.Add(this.insideLift);
            this.Controls.Add(this.rightSideDoorUpFloor);
            this.Controls.Add(this.leftSideDoorUpFloor);
            this.Controls.Add(this.rightSideDoorsGroundFloor);
            this.Controls.Add(this.leftSideDoorsGroundFloor);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.liftGroundFloor);
            this.Controls.Add(this.liftFirstFloor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "backGround";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liftas";
            this.Load += new System.EventHandler(this.backGround_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestButtonDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestButtonUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insideLift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSideDoorUpFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSideDoorUpFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSideDoorsGroundFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSideDoorsGroundFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftGroundFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftFirstFloor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox liftFirstFloor;
        private System.Windows.Forms.PictureBox liftGroundFloor;
        private System.Windows.Forms.PictureBox buttonUp;
        private System.Windows.Forms.PictureBox buttonDown;
        private System.Windows.Forms.PictureBox leftSideDoorsGroundFloor;
        private System.Windows.Forms.PictureBox rightSideDoorsGroundFloor;
        private System.Windows.Forms.Timer timerLiftUp;
        private System.Windows.Forms.Timer timerLiftDown;
        private System.Windows.Forms.Timer timerLiftUpDoorsOpen;
        private System.Windows.Forms.Timer timerLiftUpDoorsClosed;
        private System.Windows.Forms.Timer timerLiftDownDoorsOpen;
        private System.Windows.Forms.Timer timerLiftDownDoorsClosed;
        private System.Windows.Forms.PictureBox leftSideDoorUpFloor;
        private System.Windows.Forms.PictureBox rightSideDoorUpFloor;
        private System.Windows.Forms.PictureBox insideLift;
        private System.Windows.Forms.ListBox dataBaseListBox;
        private System.Windows.Forms.PictureBox clearListBox;
        private System.Windows.Forms.PictureBox requestButtonUp;
        private System.Windows.Forms.PictureBox requestButtonDown;
        private System.Windows.Forms.PictureBox exitButton;
    }
}

