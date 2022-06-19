
namespace Restaurant
{
    partial class Form2
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnLogOut = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnAddServer = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveItems = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateItems = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddItems = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlaceOrder = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2Button();
            this.uC_Welcome3 = new Restaurant.AllUserControl.UC_Welcome();
            this.uC_AddServer1 = new Restaurant.AllUserControl.UC_AddServer();
            this.uC_RemoveItem1 = new Restaurant.AllUserControl.UC_RemoveItem();
            this.uC_UpdateItems2 = new Restaurant.AllUserControl.UC_UpdateItems();
            this.uC_Welcome2 = new Restaurant.AllUserControl.UC_Welcome();
            this.uC_UpdateItems1 = new Restaurant.AllUserControl.UC_UpdateItems();
            this.uC_PlaceOrder1 = new Restaurant.AllUserControl.UC_PlaceOrder();
            this.uC_Additems1 = new Restaurant.AllUserControl.UC_Additems();
            this.uC_Welcome1 = new Restaurant.AllUserControl.UC_Welcome();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnLogOut.Controls.Add(this.guna2Button2);
            this.btnLogOut.Controls.Add(this.linkLabel1);
            this.btnLogOut.Controls.Add(this.btnAddServer);
            this.btnLogOut.Controls.Add(this.btnRemoveItems);
            this.btnLogOut.Controls.Add(this.btnUpdateItems);
            this.btnLogOut.Controls.Add(this.btnAddItems);
            this.btnLogOut.Controls.Add(this.btnPlaceOrder);
            this.btnLogOut.Controls.Add(this.panel2);
            this.guna2Transition1.SetDecoration(this.btnLogOut, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLogOut.Location = new System.Drawing.Point(0, 15);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(267, 633);
            this.btnLogOut.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.linkLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(90, 587);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 25);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnAddServer
            // 
            this.btnAddServer.BorderRadius = 14;
            this.btnAddServer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddServer.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddServer.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2Transition1.SetDecoration(this.btnAddServer, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAddServer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddServer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddServer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddServer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddServer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnAddServer.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnAddServer.ForeColor = System.Drawing.Color.White;
            this.btnAddServer.Location = new System.Drawing.Point(4, 416);
            this.btnAddServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(269, 50);
            this.btnAddServer.TabIndex = 4;
            this.btnAddServer.Text = "Add Server";
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.BorderRadius = 14;
            this.btnRemoveItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRemoveItems.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRemoveItems.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2Transition1.SetDecoration(this.btnRemoveItems, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRemoveItems.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveItems.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveItems.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveItems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveItems.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnRemoveItems.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnRemoveItems.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItems.Location = new System.Drawing.Point(16, 326);
            this.btnRemoveItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(269, 50);
            this.btnRemoveItems.TabIndex = 3;
            this.btnRemoveItems.Text = "Remove items";
            this.btnRemoveItems.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnUpdateItems
            // 
            this.btnUpdateItems.BorderRadius = 14;
            this.btnUpdateItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateItems.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdateItems.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2Transition1.SetDecoration(this.btnUpdateItems, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUpdateItems.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateItems.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateItems.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateItems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateItems.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnUpdateItems.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnUpdateItems.ForeColor = System.Drawing.Color.White;
            this.btnUpdateItems.Location = new System.Drawing.Point(16, 234);
            this.btnUpdateItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateItems.Name = "btnUpdateItems";
            this.btnUpdateItems.Size = new System.Drawing.Size(269, 50);
            this.btnUpdateItems.TabIndex = 3;
            this.btnUpdateItems.Text = "Update items";
            this.btnUpdateItems.Click += new System.EventHandler(this.btnUpdateItems_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BorderRadius = 14;
            this.btnAddItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddItems.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddItems.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2Transition1.SetDecoration(this.btnAddItems, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAddItems.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddItems.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddItems.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddItems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddItems.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnAddItems.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnAddItems.ForeColor = System.Drawing.Color.White;
            this.btnAddItems.Location = new System.Drawing.Point(16, 144);
            this.btnAddItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(269, 50);
            this.btnAddItems.TabIndex = 2;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BorderRadius = 14;
            this.btnPlaceOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPlaceOrder.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPlaceOrder.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.guna2Transition1.SetDecoration(this.btnPlaceOrder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnPlaceOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaceOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaceOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlaceOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlaceOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnPlaceOrder.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(16, 60);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(269, 50);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(309, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 633);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.uC_Welcome3);
            this.panel3.Controls.Add(this.uC_AddServer1);
            this.panel3.Controls.Add(this.uC_RemoveItem1);
            this.panel3.Controls.Add(this.uC_UpdateItems2);
            this.panel3.Controls.Add(this.uC_Welcome2);
            this.panel3.Controls.Add(this.uC_UpdateItems1);
            this.panel3.Controls.Add(this.uC_PlaceOrder1);
            this.panel3.Controls.Add(this.uC_Additems1);
            this.panel3.Controls.Add(this.uC_Welcome1);
            this.guna2Transition1.SetDecoration(this.panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(264, 40);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1047, 587);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.ScaleAndRotate;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            this.guna2Transition1.MaxAnimationTime = 3000;
            // 
            // guna2GradientCircleButton1
            // 
            this.guna2Transition1.SetDecoration(this.guna2GradientCircleButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientCircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientCircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(1284, 2);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(43, 31);
            this.guna2GradientCircleButton1.TabIndex = 6;
            this.guna2GradientCircleButton1.Text = "X";
            this.guna2GradientCircleButton1.Click += new System.EventHandler(this.guna2GradientCircleButton1_Click_2);
            // 
            // uC_Welcome3
            // 
            this.uC_Welcome3.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_Welcome3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Welcome3.Location = new System.Drawing.Point(0, 0);
            this.uC_Welcome3.Margin = new System.Windows.Forms.Padding(5);
            this.uC_Welcome3.Name = "uC_Welcome3";
            this.uC_Welcome3.Size = new System.Drawing.Size(1016, 633);
            this.uC_Welcome3.TabIndex = 8;
            this.uC_Welcome3.Load += new System.EventHandler(this.uC_Welcome3_Load);
            // 
            // uC_AddServer1
            // 
            this.uC_AddServer1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_AddServer1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_AddServer1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddServer1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_AddServer1.Name = "uC_AddServer1";
            this.uC_AddServer1.Size = new System.Drawing.Size(1025, 633);
            this.uC_AddServer1.TabIndex = 7;
            // 
            // uC_RemoveItem1
            // 
            this.uC_RemoveItem1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_RemoveItem1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_RemoveItem1.Location = new System.Drawing.Point(0, -4);
            this.uC_RemoveItem1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_RemoveItem1.Name = "uC_RemoveItem1";
            this.uC_RemoveItem1.Size = new System.Drawing.Size(1041, 633);
            this.uC_RemoveItem1.TabIndex = 6;
            // 
            // uC_UpdateItems2
            // 
            this.uC_UpdateItems2.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_UpdateItems2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_UpdateItems2.Location = new System.Drawing.Point(0, -4);
            this.uC_UpdateItems2.Margin = new System.Windows.Forms.Padding(5);
            this.uC_UpdateItems2.Name = "uC_UpdateItems2";
            this.uC_UpdateItems2.Size = new System.Drawing.Size(1041, 633);
            this.uC_UpdateItems2.TabIndex = 5;
            // 
            // uC_Welcome2
            // 
            this.uC_Welcome2.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_Welcome2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Welcome2.Location = new System.Drawing.Point(0, 0);
            this.uC_Welcome2.Margin = new System.Windows.Forms.Padding(5);
            this.uC_Welcome2.Name = "uC_Welcome2";
            this.uC_Welcome2.Size = new System.Drawing.Size(1041, 633);
            this.uC_Welcome2.TabIndex = 4;
            // 
            // uC_UpdateItems1
            // 
            this.uC_UpdateItems1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_UpdateItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_UpdateItems1.Location = new System.Drawing.Point(0, 0);
            this.uC_UpdateItems1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_UpdateItems1.Name = "uC_UpdateItems1";
            this.uC_UpdateItems1.Size = new System.Drawing.Size(1041, 633);
            this.uC_UpdateItems1.TabIndex = 3;
            // 
            // uC_PlaceOrder1
            // 
            this.uC_PlaceOrder1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_PlaceOrder1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(0, -4);
            this.uC_PlaceOrder1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(1041, 633);
            this.uC_PlaceOrder1.TabIndex = 2;
            // 
            // uC_Additems1
            // 
            this.uC_Additems1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_Additems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Additems1.Location = new System.Drawing.Point(4, 0);
            this.uC_Additems1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_Additems1.Name = "uC_Additems1";
            this.uC_Additems1.Size = new System.Drawing.Size(1021, 633);
            this.uC_Additems1.TabIndex = 1;
            // 
            // uC_Welcome1
            // 
            this.uC_Welcome1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_Welcome1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Welcome1.Location = new System.Drawing.Point(11, 0);
            this.uC_Welcome1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_Welcome1.Name = "uC_Welcome1";
            this.uC_Welcome1.Size = new System.Drawing.Size(1005, 585);
            this.uC_Welcome1.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Transition1.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1235, -3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(54, 35);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "-";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Transition1.SetDecoration(this.guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(0, -13);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(236, 53);
            this.guna2Button2.TabIndex = 8;
            this.guna2Button2.Text = "lsi restaurant";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1339, 662);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2GradientCircleButton1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnLogOut);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.btnLogOut.ResumeLayout(false);
            this.btnLogOut.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnLogOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnPlaceOrder;
        private Guna.UI2.WinForms.Guna2Button btnRemoveItems;
        private Guna.UI2.WinForms.Guna2Button btnUpdateItems;
        private Guna.UI2.WinForms.Guna2Button btnAddItems;
        private Guna.UI2.WinForms.Guna2Button btnAddServer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private AllUserControl.UC_Welcome uC_Welcome1;
        private AllUserControl.UC_Additems uC_Additems1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AllUserControl.UC_PlaceOrder uC_PlaceOrder1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private AllUserControl.UC_UpdateItems uC_UpdateItems1;
        private AllUserControl.UC_Welcome uC_Welcome2;
        private AllUserControl.UC_UpdateItems uC_UpdateItems2;
        private AllUserControl.UC_RemoveItem uC_RemoveItem1;
        private AllUserControl.UC_AddServer uC_AddServer1;
        private AllUserControl.UC_Welcome uC_Welcome3;
        private Guna.UI2.WinForms.Guna2Button guna2GradientCircleButton1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}